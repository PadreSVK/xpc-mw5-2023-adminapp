import React, { Component } from 'react';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import '../styles/NavMenu.css';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render() {
    return (
      <header>
        <Navbar className="navbar-expand-md navbar-toggleable-md ng-white border-bottom" container light>
          <NavbarBrand className="d-flex align-items-center" tag={Link} to="/">
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
            </NavbarBrand>
          <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
          <Collapse className="d-md-inline-flex flex-md-row-reverse" isOpen={!this.state.collapsed} navbar>
            <ul className="navbar-nav flex-grow text-center text-uppercase">
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/" onClick={() => this.setState({ collapsed: true })}>Domů</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/gallery" onClick={() => this.setState({ collapsed: true })}>Galerie</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark" to="/contact" onClick={() => this.setState({ collapsed: true })}>Kontakt</NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="text-dark last-nav-link" to="/registration" onClick={() => this.setState({ collapsed: true })}>Přihláška</NavLink>
              </NavItem>
            </ul>
          </Collapse>
        </Navbar>
      </header>
    );
  }
}
