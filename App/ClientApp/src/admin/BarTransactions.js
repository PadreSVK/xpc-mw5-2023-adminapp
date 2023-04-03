import React, {useState} from 'react';
import {Table} from 'reactstrap';
import * as XLSX from 'xlsx';
import {saveAs} from 'file-saver';

const barTransactions = [
    { id: 1, drinks: 'rum', paymentMethod: 'card', amount: '50' },
    { id: 2, drinks: 'rum, vodka', paymentMethod: 'cash', amount: '100' },
    { id: 3, drinks: 'cuba libre', paymentMethod: 'card', amount: '90' },
];

const paymentMethodOptions = [
    { value: 'All', label: 'All' },
    { value: 'card', label: 'card' },
    { value: 'cash', label: 'cash' },
];

const BarTransactions = () => {
    const [selectedPaymentMethod, setSelectedPaymentMethod] = useState('All');

    const handlePaymentMethodChange = (e) => {
        setSelectedPaymentMethod(e.target.value);
    };

    const filteredTransactions = barTransactions.filter((transaction) => {
        return selectedPaymentMethod === 'All' || transaction.paymentMethod === selectedPaymentMethod;
    });

    const handleExportFBarTransactionsAll = () => {
        const currentDate = new Date().toLocaleDateString().replaceAll('/', '-');
        const workbook = XLSX.utils.book_new();
        const worksheet = XLSX.utils.json_to_sheet(filteredTransactions);
        XLSX.utils.book_append_sheet(workbook, worksheet, 'Finances');
        const excelFile = XLSX.write(workbook, { bookType: 'xlsx', type: 'binary' });
        const buffer = new ArrayBuffer(excelFile.length);
        const view = new Uint8Array(buffer);
        for (let i = 0; i < excelFile.length; i++) {
            view[i] = excelFile.charCodeAt(i) & 0xFF;
        }
        const blob = new Blob([buffer], { type: 'application/octet-stream' });
        saveAs(blob, `bartransactions-${currentDate}.xlsx`);
    };

    const totalAmount = barTransactions.reduce((sum, barTransaction) => sum + parseFloat(barTransaction.amount), 0);

    return (
        <>

            <h1>Transakce na baru</h1>
            <h3>Celkem: {totalAmount.toFixed(2)}</h3>
            <label htmlFor="paymentmethod-select">Payment method:</label>
            <select id="paymentmethod-select" value={selectedPaymentMethod} onChange={handlePaymentMethodChange}>
                {paymentMethodOptions.map((option) => (
                    <option key={option.value} value={option.value}>
                        {option.label}
                    </option>
                ))}
            </select>
            <div>
                <button onClick={handleExportFBarTransactionsAll}>Export All</button>
            </div>
            <Table>
                <thead>
                <tr>
                    <th>Drinks</th>
                    <th>Payment method</th>
                    <th>Amount</th>
                </tr>
                </thead>
                <tbody>
                {filteredTransactions.map((transaction) => (
                    <tr key={transaction.id}>
                        <td>{transaction.drinks}</td>
                        <td>{transaction.paymentMethod}</td>
                        <td>{transaction.amount}</td>
                    </tr>
                ))}
                </tbody>
            </Table>
        </>
    );
};

export default BarTransactions;