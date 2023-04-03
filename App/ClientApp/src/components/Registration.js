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

const RegistrationForm = () => {
    const [formData, setFormData] = useState({
        firstName: "",
        lastName: "",
        email: "",
        phone: "",
        department: "",
        birthdate: "",
        multipleEmails: "",
        gender: "",
        transport: "",
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
            <h1>Nová přihláška</h1>
            <h5>Už jsem se přihlásil, <NavItem tag={Link} className="text-dark" to="/login">editovat přihlášku</NavItem></h5>
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
            <FormGroup tag="fieldset">
                <legend>Pohlaví</legend>
                <FormGroup check>
                    <Label check>
                        <Input
                            type="radio"
                            name="gender"
                            value="male"
                            onChange={handleChange}
                        />{" "}
                        Muž
                    </Label>
                </FormGroup>
                <FormGroup check>
                    <Label check>
                        <Input
                            type="radio"
                            name="gender"
                            value="female"
                            onChange={handleChange}
                        />{" "}
                        Žena
                    </Label>
                </FormGroup>
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
                    <option value="car">Bus</option>
                    <option value="bus">Vlastní</option>
                </Input>
            </FormGroup>
            <Button className="btn" type="submit">
                Odeslat přihlášku
            </Button>
        </Form>
        </div>
    );
};

export default RegistrationForm;

