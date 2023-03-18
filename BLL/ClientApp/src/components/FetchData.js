import React, { Component } from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { registrations: [], loading: true };
    }

    componentDidMount() {
        this.populateData();
    }

    static renderTable(registrations) {
        return (
            <table className="table table-striped" aria-labelledby="tableLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>FirstName</th>
                        <th>LastName</th>
                        <th>EmailAddress</th>
                        <th>PhoneNumber</th>
                        <th>Department</th>
                        <th>BirthDate</th>
                        <th>Gender</th>
                        <th>TransportMode</th>
                    </tr>
                </thead>
                <tbody>
                    <tr key={registrations.id}>
                        <td>{registrations.id}</td>
                        <td>{registrations.firstName}</td>
                        <td>{registrations.lastName}</td>
                        <td>{registrations.emailAddress.email}</td>
                        <td>{registrations.phoneNumber}</td>
                        <td>{registrations.department.departmentName}</td>
                        <td>{registrations.birthDate}</td>
                        <td>{registrations.gender}</td>
                        <td>{registrations.transportMode}</td>
                    </tr>
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderTable(this.state.registrations);

        return (
            <div>
                <h1 id="tableLabel">Registration</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateData() {
        const response = await fetch('registration');
        const data = await response.json();
        this.setState({ registrations: data, loading: false });
    }
}