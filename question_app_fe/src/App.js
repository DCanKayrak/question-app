import { Routes, Route, Navigate } from 'react-router-dom';
import { MainPage } from './pages/MainPage';
import { ErrorPage } from './pages/ErrorPage';
import { Login } from './pages/Login';
import { Register } from './pages/Register';
import { Question } from './pages/Question';
import { MakeQuestion } from "./pages/MakeQuestion";

const isAuthenticated = () => {
  const tokenKey = localStorage.getItem('tokenKey');
  return !!tokenKey;
};

const PrivateRoute = ({ path, element }) => {
  return isAuthenticated() ? (
    element
  ) : (
    <Navigate to="/login" />
  );
};

function App() {
  return (
    <div className="App">
      <Routes>
        {/* Auth Routes */}
        <Route path='/login' element={<Login />} />
        <Route path='/register' element={<Register />} />

        {/* Private Routes */}
        <Route
          path='/'
          element={<PrivateRoute path='/' element={<MainPage />} />}
        />
        <Route
          path='/questions/make'
          element={<PrivateRoute path='/questions/make' element={<MakeQuestion />} />}
        />
        <Route
          path='/questions/:questionId'
          element={<PrivateRoute path='/questions/:questionId' element={<Question />} />}
        />

        {/* Error Route */}
        <Route path='*' element={<ErrorPage />} />
      </Routes>
    </div>
  );
}

export default App;
