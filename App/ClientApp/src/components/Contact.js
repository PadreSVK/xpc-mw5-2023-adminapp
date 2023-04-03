import React from 'react';
import {Container, Row, Col, NavItem, NavLink} from 'reactstrap';
import '../styles/Contact.css'
import {FaEnvelope, FaFacebookF, FaInstagram} from "react-icons/fa";

const Contact = () => {
    return (
        <Container fluid className="d-flex justify-content-center align-items-center mt-5 full-height">
            <Row>
                <Col>
                    <h1 className="text-center">Důležité kontakty</h1>
                    <ul className="list-unstyled text-center">
                        <NavItem>
                            <NavLink href="https://www.instagram.com/" target="_blank" rel="noopener noreferrer" className="text-dark mt-5 mb-5"><FaInstagram className="me-2" />Instagram</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink href="https://www.facebook.com/" target="_blank" rel="noopener noreferrer" className="text-dark mt-5 mb-5"><FaFacebookF className="me-2" />Facebook</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink href="mailto:info@company.com" className="text-dark mt-5 mb-5"><FaEnvelope className="me-2" />E-mail</NavLink>
                        </NavItem>
                        <li className="mt-5 mb-5">
                            <p>Adapťák pořádá Adapťák s.r.o.</p>
                            <p>IČO: XXXXXX</p>
                            <p>Společnost zapsaná u bla bla</p>
                        </li>
                    </ul>
                </Col>
            </Row>
        </Container>
    );
};

export default Contact;