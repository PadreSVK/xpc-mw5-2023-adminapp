import React, { useState } from "react";
import {
    Form,
    FormGroup,
    Label,
    Input,
    Button,
    Col,
    Row, NavItem,
} from "reactstrap";
import {Link} from "react-router-dom";
import PersonalDataForm from "./PersonalData";

const EditRegistrationForm = () => {
    const [formData, setFormData] = useState({
        firstName: "John",
        lastName: "Doe",
        email: "johndoe@example.com",
        phone: "123-456-7890",
        department: "car",
        school: "University of Example",
        session: "1",
        birthdate: "1990-01-01",
        multipleEmails: ["Jane Smith", "Bob Johnson"],
        gender: "male",
        transport: "bus",
        status: "participant"
    });

    const handleChange = (e) => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value,
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(formData);
        // Do something with the form data, e.g. send it to a server
    };

    return (
        <div>
            <h1>Moje přihláška</h1>
            <Form onSubmit={handleSubmit}>
                <Row form>
                    <Col md={6}>
                        <FormGroup>
                            <Label for="firstName">Jméno</Label>
                            <Input
                                type="text"
                                name="firstName"
                                id="firstName"
                                value={formData.firstName}
                                onChange={handleChange}
                            />
                        </FormGroup>
                    </Col>
                    <Col md={6}>
                        <FormGroup>
                            <Label for="lastName">Příjmení</Label>
                            <Input
                                type="text"
                                name="lastName"
                                id="lastName"
                                value={formData.lastName}
                                onChange={handleChange}
                            />
                        </FormGroup>
                    </Col>
                </Row>
                <FormGroup>
                    <Label for="email">E-mail</Label>
                    <Input
                        type="email"
                        name="email"
                        id="email"
                        value={formData.email}
                        onChange={handleChange}
                    />
                </FormGroup>
                <FormGroup>
                    <Label for="phone">Telefonní číslo</Label>
                    <Input
                        type="tel"
                        name="phone"
                        id="phone"
                        value={formData.phone}
                        onChange={handleChange}
                    />
                </FormGroup>
                <FormGroup>
                    <Label for="transport">Fakulta</Label>
                    <Input
                        type="select"
                        name="department"
                        id="department"
                        value={formData.department}
                        onChange={handleChange}
                    >
                        <option value="">Vybrat...</option>
                        <option value="car">FSS je hovno</option>
                        <option value="bus">FSS je fakt hovno</option>
                        <option value="train">A znovu, FSS je hovno</option>
                    </Input>
                </FormGroup>
                <FormGroup>
                    <Label for="birthdate">Datum narození</Label>
                    <Input
                        type="date"
                        name="birthdate"
                        id="birthdate"
                        value={formData.birthdate}
                        onChange={handleChange}
                    />
                </FormGroup>
                <FormGroup>
                    <Label for="multipleEmails">Spolubydlící</Label>
                    <Input
                        type="text"
                        name="multipleEmails"
                        id="multipleEmails"
                        value={formData.multipleEmails}
                        onChange={handleChange}
                    />
                    <small className="text-muted">
                        Zadej e-maily, tvojich kamarádů a odděl je čárkou [,]. Maximálně 3.
                    </small>
                </FormGroup>
                <FormGroup>
                    <Label for="gender">Pohlaví</Label>
                    <Input
                        type="select"
                        name="gender"
                        id="gender"
                        value={formData.gender}
                        onChange={handleChange}
                    >
                        <option value="">Vybrat...</option>
                        <option value="male">Muž</option>
                        <option value="female">Žena</option>
                    </Input>
                </FormGroup>
                <FormGroup>
                    <Label for="transport">Způsob dopravy</Label>
                    <Input
                        type="select"
                        name="transport"
                        id="transport"
                        value={formData.transport}
                        onChange={handleChange}
                    >
                        <option value="">Vybrat...</option>
                        <option value="bus">Bus</option>
                        <option value="other">Vlastní</option>
                    </Input>
                </FormGroup>
                <Button className="btn" type="submit">
                    Uložit změny
                </Button>
            </Form>
            {formData.status === "participant" && <PersonalDataForm />}
        </div>
    );
};

export default EditRegistrationForm;

