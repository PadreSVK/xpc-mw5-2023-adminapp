import React from 'react';
import {Container, Row, Col, NavItem, NavLink} from 'reactstrap';
import { FaFacebookF, FaInstagram, FaEnvelope} from "react-icons/fa";
import { BiCopyright} from "react-icons/bi";
import {Link} from "react-router-dom";
import '../styles/Footer.css'

const Footer = () => {
    return (
        <footer className="py-3">
            <Container>
                <Row className="text-center text-md-end text-uppercase pt-3 pb-3 mb-3 border-top border-bottom">
                    <nav className="nav justify-content-evenly">
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="/">Domů</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="/contact">Galerie</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="/gallery">Kontakt</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink tag={Link} className="text-dark last-nav-link" to="/registration">Přihláška</NavLink>
                        </NavItem>
                    </nav>
                </Row>
                <Row>
                    <Col md="6" className="text-md-start mb-3 mb-md-0 d-flex align-items-center logo-footer">
                        <div>
                            <img
                                alt="Adapťák logo"
                                src={require('../images/adaptak_logo.png')}
                                className="me-2 logo"
                            />
                        </div>
                        <div className="text-start">
                            <div>Adapťák</div>
                            <div className="text-muted">Pro studenty</div>
                        </div>
                        <div>
                            <img
                                alt="VŠPJ logo"
                                src={require('../images/vspj_logo.png')}
                                className="ms-2 logo"
                            />
                        </div>
                    </Col>
                    <Col md="6" className="text-center text-md-end">
                        <nav className="nav justify-content-center justify-content-md-end">
                            <NavItem>
                                <NavLink tag={Link} className="text-dark" to="/"><FaInstagram className="me-2" />Instagram</NavLink>
                            </NavItem>
                            <NavItem>
                                <NavLink tag={Link} className="text-dark" to="/"><FaFacebookF className="me-2" />Facebook</NavLink>
                            </NavItem>
                            <NavItem>
                                <NavLink tag={Link} className="text-dark" to="/"><FaEnvelope className="me-2" />E-mail</NavLink>
                            </NavItem>
                        </nav>
                    </Col>
                </Row>
                <Row className="text-center border-top mt-3 pt-3">
                    <p>2023<BiCopyright className="me-2 ms-2" />Adapťák s.r.o.</p>
                </Row>
            </Container>
        </footer>
    );
};

export default Footer;
