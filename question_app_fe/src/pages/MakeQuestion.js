import React from 'react'
import Header from '../components/Header'
import Footer from '../components/Footer'

export const MakeQuestion = () => {
  return (
    <div>
      <Header/>

      <div className='container'>
      <div className='mt-5'>
        <h5>Soru Sor</h5>
        <hr></hr>
            <div className=''>
                <div class="mb-3">
                    <label for="exampleFormControlTextarea1" class="form-label">Sorunuzu öğretmenlerimize buradan anlatarak sorabilirsiniz</label>
                    <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
                </div>

                <button className='btn btn-success'>
                    Soru Sor!
                </button>
            </div>
        </div>
      </div>

      <Footer/>
    </div>
  )
}
