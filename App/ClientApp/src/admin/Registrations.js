import React, { useState } from 'react';
import { Table } from 'reactstrap';
import { Link } from 'react-router-dom';
import * as XLSX from 'xlsx';
import { saveAs } from 'file-saver';

const registrations = [
    { id: 1, firstName: 'John', lastName: 'Doe', email: 'johndoe@example.com', session: '1', department: 'FSS', status: 'participant' },
    { id: 2, firstName: 'Jane', lastName: 'Doe', email: 'janedoe@example.com', session: '2', department: 'FSS', status: 'deposit' },
    { id: 3, firstName: 'Alice', lastName: 'Smith', email: 'alicesmith@example.com', session: '3', department: 'CS', status: 'registered' },
    { id: 4, firstName: 'Bob', lastName: 'Johnson', email: 'bobjohnson@example.com', session: '1', department: 'ECE', status: 'participant' },
    { id: 5, firstName: 'Emily', lastName: 'Davis', email: 'emilydavis@example.com', session: '2', department: 'FSS', status: 'deposit' },
    { id: 6, firstName: 'David', lastName: 'Wilson', email: 'davidwilson@example.com', session: '3', department: 'ECE', status: 'waitlist' },
    { id: 7, firstName: 'Karen', lastName: 'Taylor', email: 'karentaylor@example.com', session: '1', department: 'CS', status: 'deposit' },
    { id: 8, firstName: 'Tom', lastName: 'Lee', email: 'tomlee@example.com', session: '2', department: 'FSS', status: 'participant' },
    { id: 9, firstName: 'Mary', lastName: 'Chen', email: 'marychen@example.com', session: '3', department: 'ECE', status: 'registered' },
    { id: 10, firstName: 'Mark', lastName: 'Garcia', email: 'markgarcia@example.com', session: '1', department: 'CS', status: 'waitlist' },
    { id: 11, firstName: 'Samantha', lastName: 'Brown', email: 'samanthabrown@example.com', session: '2', department: 'FSS', status: 'participant' },
    { id: 12, firstName: 'Ryan', lastName: 'Nguyen', email: 'ryannguyen@example.com', session: '3', department: 'ECE', status: 'deposit' },
    { id: 13, firstName: 'Linda', lastName: 'Robinson', email: 'lindarobinson@example.com', session: '1', department: 'CS', status: 'registered' },
    { id: 14, firstName: 'Chris', lastName: 'Chang', email: 'chrischang@example.com', session: '2', department: 'FSS', status: 'waitlist' },
    { id: 15, firstName: 'Kelly', lastName: 'Kim', email: 'kellykim@example.com', session: '3', department: 'ECE', status: 'participant' },
    { id: 16, firstName: 'Kevin', lastName: 'Wong', email: 'kevinwong@example.com', session: '1', department: 'CS', status: 'waitlist' }
];

const sessionOptions = [
    { value: 'All', label: 'All' },
    { value: '1', label: '1' },
    { value: '2', label: '2' },
    { value: '3', label: '3' },
];

const statusOptions = [
    { value: 'All', label: 'All' },
    { value: 'participant', label: 'participant' },
    { value: 'deposit', label: 'deposit' },
    { value: 'registered', label: 'registered' },
    { value: 'waitlist', label: 'waitlist' },
];

const Registrations = () => {
    const [selectedSession, setSelectedSession] = useState('All');
    const [selectedStatus, setSelectedStatus] = useState('All');
    const [searchTerm, setSearchTerm] = useState('');

    const handleSessionChange = (e) => {
        setSelectedSession(e.target.value);
    };
    const handleStatusChange = (e) => {
        setSelectedStatus(e.target.value);
    };

    const handleExportRegistrationAll = () => {
        const currentDate = new Date().toLocaleDateString().replaceAll('/', '-');
        const workbook = XLSX.utils.book_new();
        const worksheet = XLSX.utils.json_to_sheet(filteredRegistrations);
        XLSX.utils.book_append_sheet(workbook, worksheet, 'Registrations');
        const excelFile = XLSX.write(workbook, { bookType: 'xlsx', type: 'binary' });
        const buffer = new ArrayBuffer(excelFile.length);
        const view = new Uint8Array(buffer);
        for (let i = 0; i < excelFile.length; i++) {
            view[i] = excelFile.charCodeAt(i) & 0xFF;
        }
        const blob = new Blob([buffer], { type: 'application/octet-stream' });
        saveAs(blob, `registrations-${currentDate}.xlsx`);
    };

    const handleSearch = (e) => {
        setSearchTerm(e.target.value);
    };

    const filteredRegistrations = registrations.filter((registration) => {
        const fullName = registration.firstName + ' ' + registration.lastName;
        const nameMatch = fullName.toLowerCase().includes(searchTerm.toLowerCase());
        const sessionMatch = selectedSession === 'All' || registration.session === selectedSession;
        const statusMatch = selectedStatus === 'All' || registration.status === selectedStatus;
        return nameMatch && sessionMatch && statusMatch;
    });

    return (
        <>
            <h1>Přihlášky</h1>
            <label htmlFor="name-search">Name:</label>
            <input id="name-search" type="text" value={searchTerm} onChange={handleSearch} />
            <div>
                <label htmlFor="session-select">Session:</label>
                <select id="session-select" value={selectedSession} onChange={handleSessionChange}>
                    {sessionOptions.map(option => (
                        <option key={option.value} value={option.value}>{option.label}</option>
                    ))}
                </select>
                <label htmlFor="status-select">Status:</label>
                <select id="status-select" value={selectedStatus} onChange={handleStatusChange}>
                    {statusOptions.map(option => (
                        <option key={option.value} value={option.value}>{option.label}</option>
                    ))}
                </select>

                <button onClick={handleExportRegistrationAll}>Export All</button>
            </div>
            <Table>
                <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Session</th>
                    <th>Department</th>
                    <th>Status</th>
                    <th></th>
                </tr>
                </thead>
                <tbody>
                {filteredRegistrations.map((registration) => (
                    <tr key={registration.id}>
                        <td>{registration.firstName}</td>
                        <td>{registration.lastName}</td>
                        <td>{registration.email}</td>
                        <td>{registration.session}</td>
                        <td>{registration.department}</td>
                        <td>{registration.status}</td>
                        <td>
                            <Link
                                to="/registration-detail"
                                state={{email: registration.email}}
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

export default Registrations;