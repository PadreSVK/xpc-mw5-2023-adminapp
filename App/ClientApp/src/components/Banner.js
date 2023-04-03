import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import '../styles/Banner.css';

export class Banner extends Component {
    static displayName = Banner.name;

    render() {
        return (
            <div className="full-width-picture">
                <div className="text-overlay text-light text-uppercase">
                    <h2>OFICIÁLNÍ SEZNAMOVACÍ AKCE PRO PRVÁKY VŠPJ</h2>
                    <Link to="/registration">
                        <button className="btn">Přihlásit se</button>
                    </Link>
                </div>
            </div>
        );
    }
}