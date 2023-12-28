import logo from './logo.svg';
import './App.css';

import { Routes,Route } from "react-router-dom";

function App() {
  return (
    <div className="App">
      <Routes>
        <Route exact path='/' element={<MainPage/>} />
        <Route exact path='/login' element={<Login/>}/>
        <Route exact path='/register' element={<Register/>}/>
        <Route exact path='/companies' element={<CompaniesPage/>} />
        <Route exact path='/companies/:companyId' element={<CompanyDetails/>} />
        <Route exact path='/control-panel' element={<ControlPanel/>}/>
        
        {/* Customer Panel */}
        <Route exact path='/control-panel/order-request' element={<OrderPanel/>}/>
        <Route exact path='/control-panel/order-list' element={<LastOrderList/>}/>
        <Route exact path='/control-panel/account-details' element={<AccountDetails/>}/>
        <Route exact path='/control-panel/send-message' element={<SendMessage/>}/>
        <Route exact path='/control-panel/messages' element={<MessageList/>}/>
        <Route exact path='/control-panel/rating' element={<RatingPage/>}/>
        

        {/* Corporate Panel */}
        <Route exact path='/control-panel/company/' element={<CompanyInfos/>}/>
        <Route exact path='/control-panel/company/company-list' element={<CompaniesList/>}/>
        <Route exact path='/control-panel/company/employee-list' element={<EmployeeList/>}/>
        <Route exact path='/control-panel/company/truck-list' element={<TransportList/>}/>

        {/* Error Page */}
        <Route exact path='*' element={<ErrorPage/>}/>
      </Routes>
    </div>
  );
}

export default App;
