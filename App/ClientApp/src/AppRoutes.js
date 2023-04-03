import Contact from "./components/Contact";
import { Home } from "./components/Home";
import { Gallery } from "./components/Gallery";
import RegistrationForm from "./components/Registration";
import LoginForm from "./components/Login";
import './styles/custom.css';
import EditRegistrationForm from "./components/EditRegistration";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/contact',
    element: <Contact className="full-height" />
  },
  {
    path: '/gallery',
    element: <Gallery className="full-height"/>
  },
  {
    path: '/registration',
    element: <RegistrationForm />
  },
  {
    path: '/login',
    element: <LoginForm />
  },
  {
    path: '/edit-registration',
    element: <EditRegistrationForm />
  }
];

export default AppRoutes;
