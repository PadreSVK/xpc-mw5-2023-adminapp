import React from 'react';
import { Container, Row, Col } from 'reactstrap';
import sponsor1 from '../images/adaptak_logo.png';
import sponsor2 from '../images/vspj_logo.png';
import '../styles/SponsorsLogos.css';

const SponsorLogos = () => {
    return (
        <div className="sponsor-logo-spacing">
        <h1 className="text-center mb-4">Partneři</h1>
        <Container className="sponsor-logos-container">
            <Row>
                <Col xs="12" md="4" className="sponsor-logo-wrapper">
                    <div>
                        <img src={sponsor1} alt="Sponsor 1" className="sponsor-logo pb-2" />
                        <h4 className="text-center">Adaptak</h4>
                    </div>
                </Col>
                <Col xs="12" md="4" className="sponsor-logo-wrapper">
                    <div>
                        <img src={sponsor2} alt="Sponsor 1" className="sponsor-logo pb-2" />
                        <h4 className="text-center">Adaptak</h4>
                    </div>
                </Col>
                <Col xs="12" md="4" className="sponsor-logo-wrapper">
                    <div>
                        <img src={sponsor1} alt="Sponsor 1" className="sponsor-logo pb-2" />
                        <h4 className="text-center">Adaptak</h4>
                    </div>
                </Col>
            </Row>
            <Row>
                <Col xs="12" md="4" className="sponsor-logo-wrapper">
                    <div>
                        <img src={sponsor2} alt="Sponsor 1" className="sponsor-logo pb-2" />
                        <h4 className="text-center">Adaptak</h4>
                    </div>
                </Col>
                <Col xs="12" md="4" className="sponsor-logo-wrapper">
                    <div>
                        <img src={sponsor1} alt="Sponsor 1" className="sponsor-logo pb-2" />
                        <h4 className="text-center">Adaptak</h4>
                    </div>
                </Col>
                <Col xs="12" md="4" className="sponsor-logo-wrapper">
                    <div>
                        <img src={sponsor2} alt="Sponsor 1" className="sponsor-logo pb-2" />
                        <h4 className="text-center">Adaptak</h4>
                    </div>
                </Col>
            </Row>
        </Container>
        </div>
    );
};

export default SponsorLogos;
