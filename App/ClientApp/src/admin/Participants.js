import React, { useState } from 'react';
import { Table } from 'reactstrap';
import { Link } from 'react-router-dom';
import * as XLSX from 'xlsx';
import { saveAs } from 'file-saver';

const participants = [
    { id: 1, firstName: 'John', lastName: 'Doe', email: 'johndoe@example.com', session: '1', department: 'FSS', accommodation: '69' },
    { id: 2, firstName: 'Jane', lastName: 'Doe', email: 'janedoe@example.com', session: '2', department: 'FSS', accommodation: '69' },
    { id: 3, firstName: 'Alice', lastName: 'Smith', email: 'alicesmith@example.com', session: '3', department: 'CS', accommodation: '42' },
    { id: 4, firstName: 'Bob', lastName: 'Johnson', email: 'bobjohnson@example.com', session: '1', department: 'ECE', accommodation: '16' },
    { id: 5, firstName: 'Emily', lastName: 'Davis', email: 'emilydavis@example.com', session: '2', department: 'FSS', accommodation: '69' },
    { id: 6, firstName: 'David', lastName: 'Wilson', email: 'davidwilson@example.com', session: '3', department: 'ECE', accommodation: '16' },
    { id: 7, firstName: 'Karen', lastName: 'Taylor', email: 'karentaylor@example.com', session: '1', department: 'CS', accommodation: '42' },
    { id: 8, firstName: 'Tom', lastName: 'Lee', email: 'tomlee@example.com', session: '2', department: 'FSS', accommodation: '69' },
    { id: 9, firstName: 'Mary', lastName: 'Chen', email: 'marychen@example.com', session: '3', department: 'ECE', accommodation: '16' },
    { id: 10, firstName: 'Mark', lastName: 'Garcia', email: 'markgarcia@example.com', session: '1', department: 'CS', accommodation: '42' },
    { id: 11, firstName: 'Samantha', lastName: 'Brown', email: 'samanthabrown@example.com', session: '2', department: 'FSS', accommodation: '69' },
    { id: 12, firstName: 'Ryan', lastName: 'Nguyen', email: 'ryannguyen@example.com', session: '3', department: 'ECE', accommodation: '16' },
    { id: 13, firstName: 'Linda', lastName: 'Robinson', email: 'lindarobinson@example.com', session: '1', department: 'CS', accommodation: '42' },
    { id: 14, firstName: 'Chris', lastName: 'Chang', email: 'chrischang@example.com', session: '2', department: 'FSS', accommodation: '69' },
    { id: 15, firstName: 'Kelly', lastName: 'Kim', email: 'kellykim@example.com', session: '3', department: 'ECE', accommodation: '16' },
    { id: 16, firstName: 'Kevin', lastName: 'Wong', email: 'kevinwong@example.com', session: '1', department: 'CS', accommodation: '42' }
];

const sessionOptions = [
    { value: 'All', label: 'All' },
    { value: '1', label: '1' },
    { value: '2', label: '2' },
    { value: '3', label: '3' },
];

const Participants = () => {
    const [selectedSession, setSelectedSession] = useState('All');
    const [searchTerm, setSearchTerm] = useState('');

    const handleSessionChange = (e) => {
        setSelectedSession(e.target.value);
    };

    const handleExportAll = () => {
        const currentDate = new Date().toLocaleDateString().replaceAll('/', '-');
        const workbook = XLSX.utils.book_new();
        const worksheet = XLSX.utils.json_to_sheet(filteredParticipants);
        XLSX.utils.book_append_sheet(workbook, worksheet, 'Participants');
        const excelFile = XLSX.write(workbook, { bookType: 'xlsx', type: 'binary' });
        const buffer = new ArrayBuffer(excelFile.length);
        const view = new Uint8Array(buffer);
        for (let i = 0; i < excelFile.length; i++) {
            view[i] = excelFile.charCodeAt(i) & 0xFF;
        }
        const blob = new Blob([buffer], { type: 'application/octet-stream' });
        saveAs(blob, `participants-${currentDate}.xlsx`);
    };

    const handleSearch = (e) => {
        setSearchTerm(e.target.value);
    };

    const filteredParticipants = participants.filter((participant) => {
        const fullName = participant.firstName + ' ' + participant.lastName;
        const nameMatch = fullName.toLowerCase().includes(searchTerm.toLowerCase());
        const sessionMatch = selectedSession === 'All' || participant.session === selectedSession;
        return nameMatch && sessionMatch;
    });

    return (
        <>
            <h1>Účastníci</h1>
            <label htmlFor="name-search">Name:</label>
            <input id="name-search" type="text" value={searchTerm} onChange={handleSearch} />
            <div>
                <label htmlFor="session-select">Session:</label>
                <select id="session-select" value={selectedSession} onChange={handleSessionChange}>
                    {sessionOptions.map(option => (
                        <option key={option.value} value={option.value}>{option.label}</option>
                    ))}
                </select>

                <button onClick={handleExportAll}>Export All</button>
            </div>
            <Table>
                <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Session</th>
                    <th>Department</th>
                    <th>Accommodation</th>
                    <th></th>
                </tr>
                </thead>
                <tbody>
                {filteredParticipants.map((participant) => (
                    <tr key={participant.id}>
                        <td>{participant.firstName}</td>
                        <td>{participant.lastName}</td>
                        <td>{participant.email}</td>
                        <td>{participant.session}</td>
                        <td>{participant.department}</td>
                        <td>{participant.accommodation}</td>
                        <td>
                            <Link
                                to="/participant-detail"
                                state={{email: participant.email}}
                            >
                                Detail
                            </Link>
                        </td>
                    </tr>
                ))}
                </tbody>
            </Table>
        </>
    );
};

export default Participants;
