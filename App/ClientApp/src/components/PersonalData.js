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

const PersonalDataForm = () => {
    const [formData, setFormData] = useState({
        idNumber: "",
        personalNumber: "",
        addressLine1: "",
        addressLine2: "",
        city: "",
        postalCode: "",
        country: "",
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
        <div className="mt-4">
            <h1>Osobní údaje pro kemp</h1>
            <Form onSubmit={handleSubmit}>
                <Row>
                    <Col md={6}>
                    <FormGroup>
                        <Label for="idnumber">Číslo OP:</Label>
                        <Input
                            type="text"
                            name="idnumber"
                            id="idnumber"
                            value={formData.idNumber}
                            onChange={handleChange}
                        />
                    </FormGroup>
                    </Col>
                    <Col md={6}>
                    <FormGroup>
                        <Label for="personalnumber">Rodné číslo:</Label>
                        <Input
                            type="text"
                            name="personalnumber"
                            id="personalnumber"
                            value={formData.personalNumber}
                            onChange={handleChange}
                        />
                    </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col md={6}>
                    <FormGroup>
                        <Label for="addressline1">Ulice:</Label>
                        <Input
                            type="text"
                            name="addressline1"
                            id="addressline1"
                            value={formData.addressLine1}
                            onChange={handleChange}
                        />
                    </FormGroup>
                    </Col>
                    <Col md={6}>
                    <FormGroup>
                        <Label for="addressline2">Č. p.:</Label>
                        <Input
                            type="text"
                            name="addressline2"
                            id="addressline2"
                            value={formData.addressLine2}
                            onChange={handleChange}
                        />
                    </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col md={6}>
                        <FormGroup>
                            <Label for="city">Město:</Label>
                            <Input
                                type="text"
                                name="city"
                                id="city"
                                value={formData.city}
                                onChange={handleChange}
                            />
                        </FormGroup>
                    </Col>
                    <Col md={6}>
                        <FormGroup>
                            <Label for="postalcode">PSČ:</Label>
                            <Input
                                type="text"
                                name="postalcode"
                                id="postalcode"
                                value={formData.postalCode}
                                onChange={handleChange}
                            />
                        </FormGroup>
                    </Col>
                </Row>
                <Row>
                    <Col md={6}>
                        <FormGroup>
                            <Label for="country">Země:</Label>
                            <Input
                                type="text"
                                name="country"
                                id="country"
                                value={formData.country}
                                onChange={handleChange}
                            />
                        </FormGroup>
                    </Col>
                </Row>
                <Button className="btn" type="submit">
                    Odeslat
                </Button>
            </Form>
        </div>
    );
};

export default PersonalDataForm;

