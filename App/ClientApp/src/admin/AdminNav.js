import React, { Component } from 'react';
import { Navbar, NavbarBrand } from 'reactstrap';
import { Link } from 'react-router-dom';
import '../styles/NavMenu.css';

export class AdminNav extends Component {
    static displayName = AdminNav.name;

    render() {
        return (
            <header>
                <Navbar className="navbar-expand-md ng-white border-bottom" container light>
                    <NavbarBrand className="d-flex align-items-center" tag={Link} to="/">
                        <div>
                            <img
                                alt="Adapťák logo"
                                src={require('../images/adaptak_logo.png')}
                                className="me-2 logo"
                            />
                        </div>
                        <div className="text-start">Admin</div>
                    </NavbarBrand>
                </Navbar>
            </header>
        );
    }
}