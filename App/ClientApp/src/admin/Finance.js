import React, {useState} from 'react';
import {Table} from 'reactstrap';
import * as XLSX from 'xlsx';
import {saveAs} from 'file-saver';

const finances = [
    { id: 1, firstName: 'John', lastName: 'Doe', email: 'johndoe@example.com', amount: '1500' },
    { id: 2, firstName: 'Jane', lastName: 'Doe', email: 'janedoe@example.com', amount: '2000' },
    { id: 3, firstName: 'Alice', lastName: 'Smith', email: 'alicesmith@example.com', amount: '2500' }
];

const Finances = () => {
    const [searchTerm, setSearchTerm] = useState('');

    const handleExportFinancesAll = () => {
        const currentDate = new Date().toLocaleDateString().replaceAll('/', '-');
        const workbook = XLSX.utils.book_new();
        const worksheet = XLSX.utils.json_to_sheet(finances);
        XLSX.utils.book_append_sheet(workbook, worksheet, 'Finances');
        const excelFile = XLSX.write(workbook, { bookType: 'xlsx', type: 'binary' });
        const buffer = new ArrayBuffer(excelFile.length);
        const view = new Uint8Array(buffer);
        for (let i = 0; i < excelFile.length; i++) {
            view[i] = excelFile.charCodeAt(i) & 0xFF;
        }
        const blob = new Blob([buffer], { type: 'application/octet-stream' });
        saveAs(blob, `finances-${currentDate}.xlsx`);
    };

    const handleSearch = (e) => {
        setSearchTerm(e.target.value);
    };

    const filteredFinances = finances.filter((finance) => {
        const fullName = finance.firstName + ' ' + finance.lastName;
        return fullName.toLowerCase().includes(searchTerm.toLowerCase());
    });

    const totalAmount = finances.reduce((sum, finance) => sum + parseFloat(finance.amount), 0);

    return (
        <>
            <h1>Finance</h1>
            <h3>Celkem: {totalAmount.toFixed(2)}</h3>
            <label htmlFor="name-search">Name:</label>
            <input id="name-search" type="text" value={searchTerm} onChange={handleSearch} />
            <div>
                <button onClick={handleExportFinancesAll}>Export All</button>
            </div>
            <Table>
                <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Amount</th>
                </tr>
                </thead>
                <tbody>
                {filteredFinances.map((finance) => (
                    <tr key={finance.id}>
                        <td>{finance.firstName}</td>
                        <td>{finance.lastName}</td>
                        <td>{finance.email}</td>
                        <td>{finance.amount}</td>
                    </tr>
                ))}
                </tbody>
            </Table>
        </>
    );
};

export default Finances;