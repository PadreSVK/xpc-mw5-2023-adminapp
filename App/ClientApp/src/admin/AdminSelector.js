import React from 'react';
import { Route, Routes, useNavigate } from 'react-router-dom';
import AdminRoutes from '../AdminRoutes';
import '../styles/custom.css';

function AdminSelector() {
    return (
        <div>
            <TileButtons />
            <div className="admin-content">
                <Routes>
                    {AdminRoutes.map((route, index) => (
                        <Route
                            key={index}
                            path={route.path}
                            element={route.element}
                        />
                    ))}
                </Routes>
            </div>
        </div>
    );
}

function TileButtons() {
    const navigate = useNavigate();

    const redirectToRoute = (path) => {
        navigate(path);
    };

    return (
        <div className="tiles">
            {AdminRoutes.map((route, index) => (
                route.donotshow !== true && (
                    <button
                        key={index}
                        className="tile square"
                        onClick={() => redirectToRoute(route.path)}
                    >
                        {route.displayName}
                    </button>
                )
            ))}
        </div>
    );
}

export default AdminSelector;
