import LoginForm from "./components/Login";
import './styles/custom.css';
import AdminSelector from "./admin/AdminSelector";
import Participants from "./admin/Participants";
import ParticipantDetail from "./admin/ParticipantDetail";
import Registrations from "./admin/Registrations";
import RegistrationDetail from "./admin/RegistrationDetail";
import Staff from "./admin/Staff";
import StaffDetail from "./admin/StaffDetail";
import Finances from "./admin/Finance";
import Accommodations from "./admin/Accommodations";
import AccommodationDetail from "./admin/AccomodationDetail";
import BarInventory from "./admin/BarInventory";
import BarSettings from "./admin/BarSettings";
import BarTransactions from "./admin/BarTransactions";



const AdminRoutes = [
    {
        index: true,
        donotshow: true,
        element: <AdminSelector />
    },
    {
        path: '/participants',
        element: <Participants />,
        displayName: "Účastníci"
    },
    {
        path: '/participant-detail',
        donotshow: true,
        element: <ParticipantDetail />,
        displayName: "Participant detail"
    },
    {
        path: '/registrations',
        element: <Registrations />,
        displayName: "Přihlášky"
    },
    {
        path: '/registration-detail',
        donotshow: true,
        element: <RegistrationDetail />,
        displayName: "Registration detail"
    },
    {
        path: '/staff',
        element: <Staff />,
        displayName: "Instruktoři"
    },
    {
        path: '/staff-detail',
        donotshow: true,
        element: <StaffDetail />,
        displayName: "Instruktoři detail"
    },
    {
        path: '/finances',
        element: <Finances />,
        displayName: "Finance"
    },
    {
        path: '/accomodation',
        element: <Accommodations />,
        displayName: "Ubytování"
    },
    {
        path: '/accommodation-detail',
        donotshow: true,
        element: <AccommodationDetail />,
        displayName: "Ubytování detail"
    },
    {
        path: '/bar-inventory',
        element: <BarInventory />,
        displayName: "Bar - zásoby"
    },
    {
        path: '/bar-settings',
        element: <BarSettings />,
        displayName: "Bar - nastavení"
    },
    {
        path: '/bar-transactions',
        element: <BarTransactions />,
        displayName: "Bar - transakce"
    },
    {
        path: 'frontend-settings',
        element: <LoginForm />,
        displayName: "Frontend - nastavení"
    },
    {
        path: '/currentyear-settings',
        element: <LoginForm />,
        displayName: "Aktuální ročník - nastavení"
    },
];

export default AdminRoutes;