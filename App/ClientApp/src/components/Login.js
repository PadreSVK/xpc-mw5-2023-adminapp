import React, { useState } from 'react';
import {
    Form,
    FormGroup,
    Label,
    Input,
    Button
} from 'reactstrap';
import '../styles/Login.css'

const LoginForm = () => {
    const [email, setUsername] = useState('');
    const [password, setPassword] = useState('');

    const handleLogin = (e) => {
        e.preventDefault();
        // TODO: Handle login logic
    }

    return (
        <Form onSubmit={handleLogin} className="mt-4 full-height w-50 mx-auto">
            <FormGroup>
                <Label for="email">E-mail</Label>
                <Input
                    type="email"
                    name="email"
                    id="email"
                    placeholder="Zadej e-mail"
                    value={email}
                    onChange={(e) => setUsername(e.target.value)}
                />
            </FormGroup>
            <FormGroup>
                <Label for="password">Heslo</Label>
                <Input
                    type="password"
                    name="password"
                    id="password"
                    placeholder="Zadej heslo"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                />
            </FormGroup>
            <Button type="submit">Log in</Button>
        </Form>
    );
}

export default LoginForm;
