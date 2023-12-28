import logo from './logo.svg';
import './App.css';

import { Routes,Route } from "react-router-dom";

import MainPage from './pages/MainPage';
import { ErrorPage } from './pages/ErrorPage';
import Login from './pages/Login';
import Register from './pages/Register';

function App() {
  return (
    <div className="App">
      <Routes>
        <Route exact path='/' element={<MainPage/>} />

        // Auth Routes
        <Route exact path='/login' element={<Login/>}/>
        <Route exact path='/register' element={<Register/>}/>
        
        // Error Route
        <Route exact path='*' element={<ErrorPage/>}/>
      </Routes>
    </div>
  );
}

export default App;
