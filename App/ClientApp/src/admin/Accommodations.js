import React, { useState } from 'react';
import { Table } from 'reactstrap';
import {Link} from "react-router-dom";

const accommodations = [
    { id: 1, session: '1', accommodationNumber: '2', currentOccupancy: '2', maxCapacity: '4' },
    { id: 2, session: '2', accommodationNumber: '42', currentOccupancy: '3', maxCapacity: '4' },
    { id: 3, session: '3', accommodationNumber: '69', currentOccupancy: '4', maxCapacity: '4' },
];

const sessionOptions = [
    { value: 'All', label: 'All' },
    { value: '1', label: '1' },
    { value: '2', label: '2' },
    { value: '3', label: '3' },
];

const Accommodations = () => {
    const [selectedSession, setSelectedSession] = useState('All');

    const handleSessionChange = (e) => {
        setSelectedSession(e.target.value);
    };

    const handleExportStaffAll = () => {};

    const filteredAccommodations = accommodations.filter((accommodation) => {
        return selectedSession === 'All' || accommodation.session === selectedSession;
    });

    return (
        <>
            <h1>Ubytování</h1>
            <label htmlFor="name-search">Name:</label>
            <div>
                <label htmlFor="session-select">Session:</label>
                <select id="session-select" value={selectedSession} onChange={handleSessionChange}>
                    {sessionOptions.map((option) => (
                        <option key={option.value} value={option.value}>
                            {option.label}
                        </option>
                    ))}
                </select>

                <button onClick={handleExportStaffAll}>Export All</button>
            </div>
            <Table>
                <thead>
                <tr>
                    <th>Session</th>
                    <th>Accomodation number</th>
                    <th>Capacity</th>
                    <th></th>
                </tr>
                </thead>
                <tbody>
                {filteredAccommodations.map((accommodation) => (
                    <tr key={accommodation.id}>
                        <td>{accommodation.session}</td>
                        <td>{accommodation.accommodationNumber}</td>
                        <td>
                            {accommodation.currentOccupancy}/{accommodation.maxCapacity}
                        </td>
                        <td>
                            <Link
                                to="/accommodation-detail"
                                state={{session: accommodation.session, accommodationNumber: accommodation.accommodationNumber}}
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

export default Accommodations;
