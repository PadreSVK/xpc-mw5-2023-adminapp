import React, { useState } from 'react';
import { Table } from 'reactstrap';
import { Link } from 'react-router-dom';
import * as XLSX from 'xlsx';
import { saveAs } from 'file-saver';

const staffs = [
    { id: 1, firstName: 'John', lastName: 'Doe', email: 'johndoe@example.com', school: 'su', department: 'FSS', accommodation: '69' },
    { id: 2, firstName: 'Jane', lastName: 'Doe', email: 'janedoe@example.com', school: 'vspj', department: 'FSS', accommodation: '69' },
    { id: 3, firstName: 'Alice', lastName: 'Smith', email: 'alicesmith@example.com', school: 'vspj', department: 'CS', accommodation: '42' }
];

const schoolOptions = [
    { value: 'All', label: 'All' },
    { value: 'su', label: 'SU' },
    { value: 'vspj', label: 'VŠPJ' }
];

const Staff = () => {
    const [selectedSchool, setSelectedSchool] = useState('All');
    const [searchTerm, setSearchTerm] = useState('');

    const handleSchoolChange = (e) => {
        setSelectedSchool(e.target.value);
    };

    const handleExportStaffAll = () => {
        const currentDate = new Date().toLocaleDateString().replaceAll('/', '-');
        const workbook = XLSX.utils.book_new();
        const worksheet = XLSX.utils.json_to_sheet(filteredStaff);
        XLSX.utils.book_append_sheet(workbook, worksheet, 'Staff');
        const excelFile = XLSX.write(workbook, { bookType: 'xlsx', type: 'binary' });
        const buffer = new ArrayBuffer(excelFile.length);
        const view = new Uint8Array(buffer);
        for (let i = 0; i < excelFile.length; i++) {
            view[i] = excelFile.charCodeAt(i) & 0xFF;
        }
        const blob = new Blob([buffer], { type: 'application/octet-stream' });
        saveAs(blob, `staff-${currentDate}.xlsx`);
    };

    const handleSearch = (e) => {
        setSearchTerm(e.target.value);
    };

    const filteredStaff = staffs.filter((staff) => {
        const fullName = staff.firstName + ' ' + staff.lastName;
        const nameMatch = fullName.toLowerCase().includes(searchTerm.toLowerCase());
        const sessionMatch = selectedSchool === 'All' || staff.school === selectedSchool;
        return nameMatch && sessionMatch;
    });

    return (
        <>
            <h1>Instruktoři</h1>
            <label htmlFor="name-search">Name:</label>
            <input id="name-search" type="text" value={searchTerm} onChange={handleSearch} />
            <div>
                <label htmlFor="school-select">Session:</label>
                <select id="school-select" value={selectedSchool} onChange={handleSchoolChange}>
                    {schoolOptions.map(option => (
                        <option key={option.value} value={option.value}>{option.label}</option>
                    ))}
                </select>

                <button onClick={handleExportStaffAll}>Export All</button>
            </div>
            <Table>
                <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>School</th>
                    <th>Department</th>
                    <th>Accommodation</th>
                    <th></th>
                </tr>
                </thead>
                <tbody>
                {filteredStaff.map((staff) => (
                    <tr key={staff.id}>
                        <td>{staff.firstName}</td>
                        <td>{staff.lastName}</td>
                        <td>{staff.email}</td>
                        <td>{staff.school}</td>
                        <td>{staff.department}</td>
                        <td>{staff.accommodation}</td>
                        <td>
                            <Link
                                to="/staff-detail"
                                state={{email: staff.email}}
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

export default Staff;
