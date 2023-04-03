import { Table } from 'reactstrap';
import React from "react";

const barItems = [
    { id: 1, name: 'rum', stock: '4'},
    { id: 2, name: 'vodka', stock: '30'},
    { id: 3, name: 'borovička', stock: '20'},
];

const BarInventoryTable = () => {
    return (
        <Table>
            <thead>
            <tr>
                <th>Bar item</th>
                <th>Stock</th>
                <th></th>
            </tr>
            </thead>
            <tbody>
            {barItems.map((item, index) => (
                <tr key={index} >
                    <td>{item.name}</td>
                    <td>{item.stock}</td>
                    <td>
                        <button className={item.stock < 5 ? 'bg-danger' : ''}>Refill</button>
                    </td>
                </tr>
            ))}
            </tbody>
        </Table>
    );
};

export default BarInventoryTable;
