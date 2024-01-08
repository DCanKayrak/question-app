import { React, useState, useEffect } from 'react'
import { GetWithoutAuth, PostWithAuth } from '../utils/service/HttpService';
import { useNavigate } from 'react-router-dom';

import Header from '../components/Header';
import Footer from '../components/Footer';

export const MakeQuestion = () => {
  const [title, setTitle] = useState("");
  const [description, setDescription] = useState("");
  const [categories, setCategories] = useState([]);
  const [category, setCategory] = useState("");

  const [error, setError] = useState("");
  const [success, setSuccess] = useState("");

  const navigate = useNavigate();

  const handleGetCategories = () => {
    GetWithoutAuth("https://localhost:7048/api/Category")
      .then(response => response.json())
      .then(data => setCategories(data.data))
      .catch(error => console.error('Hata:', error));
  }

  const handleAskQuestion = () => {
      const categoryId = Number(category)
      console.log(categoryId)
      PostWithAuth("https://localhost:7048/api/Question",{
        categoryId: categoryId,
        title: title,
        description: description
      })
      .then((res) => res.json())
      .then((result) => {
          if(result.success){
              setError(null)
              setSuccess(result.message)
          }
          else {
              setSuccess(null)
              setError(result.message)
          }
          
      }).catch((err) => console.log(err.message))
  }

  useEffect(() => {
    handleGetCategories()
  }, [])

  return (
    <div>
      <Header />

      <div className='container'>
        <div className='mt-5'>
          <a href='/' className='btn btn-warning'><i class="fa-solid fa-arrow-left"></i> Geri Dön</a>
          <h5 className='mt-3'>Soru Sor</h5>
          <hr></hr>
          <div className=''>
            <p>Sorunuzu öğretmenlerimize buradan anlatarak sorabilirsiniz</p>
            {success == null ? <div className='bg-danger'>{error}</div> : <div className='bg-success'>{success}</div>}
            <div class="mb-3">
              <label for="exampleFormControlTextarea1" class="form-label">Kategori</label>
              <select onChange={event => setCategory(event.target.value)} class="form-select" aria-label="Default select example">
                <option disabled selected>Seçim Yapınız</option>
                {
                  categories ? categories.map(c=>(
                    <option value={c.id}>{c.name}</option>
                  )) : "Loading"
                }
              </select>
            </div>
            <div class="mb-3">
              <label for="exampleFormControlTextarea1" class="form-label">Başlık</label>
              <input value={title} onChange={event => setTitle(event.target.value)} class="form-control" id="title" name='title'></input>
            </div>
            <div class="mb-3">
              <label for="exampleFormControlTextarea1" class="form-label">Soru İçeriği</label>
              <textarea value={description} onChange={event => setDescription(event.target.value)} class="form-control" id="description" name='description' rows="3"></textarea>
            </div>

            <button onClick={ handleAskQuestion } className='btn btn-success'>
              Soru Sor!
            </button>
          </div>
        </div>
      </div>

      <Footer />
    </div>
  )
}
