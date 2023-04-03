import React from 'react';
import { Container, Row, Col, FormGroup, Label, Input } from 'reactstrap';
import {useLocation} from "react-router-dom";

const participant = {
    firstName: "John",
    lastName: "Doe",
    email: "johndoe@example.com",
    phoneNumber: "123-456-7890",
    department: "Computer Science",
    school: "University of Example",
    userrole: "admin",
    accommodation: "69",
    birthdate: "1990-01-01",
    roommates: ["Jane Smith", "Bob Johnson"],
    gender: "Male",
    transportMode: "Car",
    idNumber: "123456",
    personalNumber: "123456/1234",
    addressLine1: "123 Main St",
    addressLine2: "Apt 4B",
    city: "Exampleville",
    postalCode: "12345",
    country: "United States",
};

const StaffDetail = () => {
    let { state } = useLocation();
    const {
        firstName,
        lastName,
        email,
        phoneNumber,
        department,
        school,
        userrole,
        accommodation,
        birthdate,
        roommates,
        gender,
        transportMode,
        idNumber,
        personalNumber,
        addressLine1,
        addressLine2,
        city,
        postalCode,
        country,
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
                        <Label for="userrole">User role:</Label>
                        <Input type="text" name="userrole" id="userrole" value={userrole} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="accomodation">Accommodation:</Label>
                        <Input type="text" name="accomodation" id="accomodation" value={accommodation} disabled />
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

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="idnumber">Číslo OP:</Label>
                        <Input type="text" name="idnumber" id="idnumber" value={idNumber} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="personalnumber">Rodné číslo:</Label>
                        <Input type="text" name="personalnumber" id="personalnumber" value={personalNumber} disabled />
                    </FormGroup>
                </Col>
            </Row>

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="addressLine1">Address Line 1:</Label>
                        <Input type="text" name="addressLine1" id="addressLine1" value={addressLine1} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="addressLine2">Address Line 2:</Label>
                        <Input type="text" name="addressLine2" id="addressLine2" value={addressLine2} disabled />
                    </FormGroup>
                </Col>
            </Row>
            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="city">City:</Label>
                        <Input type="text" name="city" id="city" value={city} disabled />
                    </FormGroup>
                </Col>
                <Col md={6}>
                    <FormGroup>
                        <Label for="postalCode">Postal Code:</Label>
                        <Input type="text" name="postalCode" id="postalCode" value={postalCode} disabled />
                    </FormGroup>
                </Col>
            </Row>

            <Row>
                <Col md={6}>
                    <FormGroup>
                        <Label for="country">Country:</Label>
                        <Input type="text" name="country" id="country" value={country} disabled />
                    </FormGroup>
                </Col>
            </Row>
        </Container>
    );
};

export default StaffDetail;

