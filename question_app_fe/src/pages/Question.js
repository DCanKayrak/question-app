import  { React, useEffect, useState } from 'react'
import { useParams } from 'react-router-dom'
import Footer from '../components/Footer';
import Header from '../components/Header';
import { MakeAnswer } from '../components/MakeAnswer';
import { GetWithoutAuth } from '../utils/service/HttpService';

export const Question = (props) => {
    const { questionId } = useParams();
    const [question, setQuestion] = useState([]);

    const GetQuestion = async () => {
        // Fetch işlemi
        GetWithoutAuth('https://localhost:7048/api/Question/'+questionId)
            .then(response => response.json())
            .then(data => setQuestion(data))
            .catch(error => console.error('Hata:', error));
    }

    const handleGetQuestion = () => {
        GetQuestion();
        console.log(question)
    }

    useEffect(() => {
        handleGetQuestion()
    }, [])

  return (
    <div>
    <Header></Header>
        <div className='container'>
            <div className='row mt-5'>
                <div className='col-9'>
                <a className='btn btn-warning'><i class="fa-solid fa-arrow-left"></i> Geri Dön</a>
                    <h5 className='mt-3'>{question.data && question.data.title}</h5>
                    <p className='mt-5'>{question.data && question.data.description}</p>
                    <MakeAnswer></MakeAnswer>
                </div>
                <div className='col-3 text-center'>
                    <h6>Soru Durumu</h6>
                    {
                        question.data && question.data.status == 1 ? <p><i style={{ color: 'red' }} class="fa-solid fa-circle-xmark"></i> Çözüm Bekliyor</p>:
                                    <p><i style={{ color: 'green' }} class="fa-solid fa-circle-check"></i> Çözüldü</p>
                    }
                </div>
            </div>
        </div>
        <Footer></Footer>
    </div>
  )
}
