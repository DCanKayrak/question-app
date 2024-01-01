import React from 'react';

import Header from '../components/Header';
import Footer from '../components/Footer';
import QuestionTable from '../components/QuestionTable';
import { Categories } from '../components/Categories';

export const MainPage = () => {
  return (
    <div>
        <Header></Header>
        
        <div className='container'>
            <div className='row mt-5'>
                <div className='col-9'>
                    <h3 className='d-flex'>Son Sorulan Sorular</h3>
                    <QuestionTable></QuestionTable>
                </div>
                <div className='col-3'>
                    <a href='/questions/make' className='btn btn-success'>Soru Sor</a>
                </div>
            </div>
            
        </div>

        <Footer></Footer>
    </div>
  )
}

