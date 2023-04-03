import React from 'react';
import {Container, Row, Col, FormGroup, Label, Input, Table} from 'reactstrap';
import {Link, useLocation} from "react-router-dom";

const participant = {
    firstName: "John",
    lastName: "Doe",
    email: "johndoe@example.com2",
    phoneNumber: "123-456-7890",
    department: "Computer Science",
    school: "University of Example",
    session: "1",
    birthdate: "1990-01-01",
    roommates: ["Jane Smith", "Bob Johnson"],
    gender: "Male",
    transportMode: "Car",
    status: "registered"
};

const RegistrationDetail = () => {
    let { state } = useLocation();
    const {
        firstName,
        lastName,
        email,
        phoneNumber,
        department,
        school,
        session,
        birthdate,
        roommates,
        gender,
        transportMode,
        status
    } = participant;



    return (
        <Container>
            {state.email && <h1>{state.email}</h1>}
            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="firstName">First Name:</Label>
                        <Input type="text" name="firstName" id="firstName" value={firstName} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="lastName">Last Name:</Label>
                        <Input type="text" name="lastName" id="lastName" value={lastName} disabled />
                    </FormGroup>
                </Col>
            </Row>

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="email">Email:</Label>
                        <Input type="email" name="email" id="email" value={email} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="phoneNumber">Phone Number:</Label>
                        <Input type="text" name="phoneNumber" id="phoneNumber" value={phoneNumber} disabled />
                    </FormGroup>
                </Col>
            </Row>

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="department">Department:</Label>
                        <Input type="text" name="department" id="department" value={department} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="school">School:</Label>
                        <Input type="text" name="school" id="school" value={school} disabled />
                    </FormGroup>
                </Col>
            </Row>

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="session">Session:</Label>
                        <Input type="text" name="session" id="session" value={session} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="accomodation">Status:</Label>
                        <Input type="text" name="accomodation" id="accomodation" value={status} disabled />
                    </FormGroup>
                </Col>
            </Row>

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="birthdate">Birthdate:</Label>
                        <Input type="date" name="birthdate" id="birthdate" value={birthdate} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="roommates">Roommates:</Label>
                        <Input type="text" name="roommates" id="roommates" value={roommates.join(", ")} disabled />
                    </FormGroup>
                </Col>
            </Row>

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="gender">Gender:</Label>
                        <Input type="text" name="gender" id="gender" value={gender} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="transportMode">Transport Mode:</Label>
                        <Input type="text" name="transportMode" id="transportMode" value={transportMode} disabled />
                    </FormGroup>
                </Col>
            </Row>

        </Container>
    );
};

export default RegistrationDetail;

