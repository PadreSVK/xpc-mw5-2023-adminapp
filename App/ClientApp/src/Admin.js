import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AdminRoutes from './AdminRoutes';
import { AdminNav } from './admin/AdminNav';
import './styles/admin.css';

export default class Admin extends Component {
    static displayName = Admin.name;

    render() {
        return (
            <div>
            <AdminNav />
                <Routes>
                    {AdminRoutes.map((route, index) => {
                        const { element, ...rest } = route;
                        return <Route key={index} {...rest} element={element} />;
                    })}
                </Routes>
            </div>
        );
    }
}