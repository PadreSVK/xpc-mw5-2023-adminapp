import React from 'react';
import {Link, useLocation} from "react-router-dom";
import {Table} from "reactstrap";

const participants = [
    { id: 1, firstName: 'John', lastName: 'Doe', email: 'johndoe@example.com' },
    { id: 2, firstName: 'Jane', lastName: 'Doe', email: 'janedoe@example.com' },
    { id: 3, firstName: 'Alice', lastName: 'Smith', email: 'alicesmith@example.com' }
];

const AccommodationDetail = () => {
    let { state } = useLocation();

    return (
        <>
            {state.session && state.accommodationNumber && <h1>Číslo ubytování: {state.accommodationNumber}, Turnus: {state.session}</h1>}
            <Table>
                <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th></th>
                </tr>
                </thead>
                <tbody>
                {participants.map((participant) => (
                    <tr key={participant.id}>
                        <td>{participant.firstName}</td>
                        <td>{participant.lastName}</td>
                        <td>{participant.email}</td>
                        <td>
                            <Link
                                to={{
                                    pathname: '/registration-detail',
                                    state: { email: participant.email },
                                }}
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

export default AccommodationDetail;
