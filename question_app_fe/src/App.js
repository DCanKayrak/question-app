import { Routes,Route } from "react-router-dom";

import { MainPage } from './pages/MainPage';
import { ErrorPage } from './pages/ErrorPage';
import { Login } from './pages/Login';
import { Register } from './pages/Register';
import {Question} from './pages/Question';
import { MakeQuestion } from "./pages/MakeQuestion";

function App() {
  return (
    <div className="App">
      <Routes>
        // Auth Routes
        <Route exact path='/login' element={<Login/>}/>
        <Route exact path='/register' element={<Register/>}/>

        // Main Routes
        <Route exact path='/' element={<MainPage/>} />
        <Route exact path='/questions/make' element={<MakeQuestion/>}/>
        <Route exact path='/questions/:questionId' element={<Question/>}/>

        
        // Error Route
        <Route exact path='*' element={<ErrorPage/>}/>
      </Routes>
    </div>
  );
}

export default App;
