import React, { Component } from 'react';
import { Container, Row, Col } from 'reactstrap';
import '../styles/SessionDates.css'

export class SessionDates extends Component {
    static displayName = SessionDates.name;
    render() {
        return (
        <Container className="session-dates pt-4">
            <Row className="justify-content-center align-items-center mt-4 mb-5 text-center">
                <Col md="6" className="mb-4 mb-md-0">
                    <h1>Termíny:</h1>
                </Col>
                <Col md="6">
                    <h2>11.9. - 13.9.2023</h2>
                    <h2>13.9. - 15.9.2023</h2>
                </Col>
            </Row>
        </Container>
        );
    }
}