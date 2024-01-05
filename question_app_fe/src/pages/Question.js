import React, { useEffect } from 'react'
import { useParams } from 'react-router-dom'
import Footer from '../components/Footer';
import Header from '../components/Header';
import { MakeAnswer } from '../components/MakeAnswer';
import { GetWithoutAuth } from '../utils/service/HttpService';

export const Question = (props) => {
    const { questionId } = useParams();

    const GetQuestions = () => {
        // Fetch işlemi
fetch('https://localhost:7048/api/Question')
.then(response => response.json())
.then(data => console.log(data))
.catch(error => console.error('Hata:', error));

    }

    const handleGetQuestions = () => {
        console.log(GetQuestions);
    }

    useEffect(() => {
        GetQuestions();
      }, [])

  return (
    <div>
    <Header></Header>
        <div className='container'>
            <div className='row mt-5'>
                <div className='col-9'>
                    <h5 className=''>Title</h5>
                    <p className='mt-5'>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>
                    <MakeAnswer></MakeAnswer>
                </div>
                <div className='col-3 text-center'>
                    <h6>Soru Durumu</h6>
                    <p><i style={{color: 'green'}} class="fa-solid fa-circle-check"></i> Çözüldü</p>
                </div>
            </div>
        </div>
        <Footer></Footer>
    </div>
  )
}
