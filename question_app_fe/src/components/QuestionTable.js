import { React, useEffect, useState } from 'react';
import { GetWithoutAuth } from '../utils/service/HttpService';

export default function QuestionTable() {
    const [questions, setQuestions] = useState([]);

    const GetQuestions = () => {
        // Fetch işlemi
        GetWithoutAuth('https://localhost:7048/api/Question')
            .then(response => response.json())
            .then(data => setQuestions(data.data))
            .catch(error => console.error('Hata:', error));

    }

    const handleGetQuestions = () => {
        GetQuestions();
    }

    useEffect(() => {
        handleGetQuestions()
    }, [])

    return (
        <div>
            <table class="table text-center">
                <thead>
                    <tr>
                        <th scope="col">Başlık</th>
                        <th scope="col">Kategori</th>
                        <th scope="col">Durum</th>
                        <th scope='col'>Soru Sahibi</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        questions.map(q => {
                            return (<tr>
                                <th scope="row"><a href={'/questions/'+q.id}>{q.title}</a></th>
                                <td>{q.categoryId}</td>
                                <td>{
                                    q.status == 1 ? <p><i style={{ color: 'red' }} class="fa-solid fa-circle-xmark"></i> Çözüm Bekliyor</p>:
                                    <p><i style={{ color: 'green' }} class="fa-solid fa-circle-check"></i> Çözüldü</p>
                                }</td>
                                <td>Mehmet</td>
                            </tr>)
                        })
                    }
                </tbody>
            </table>
        </div>
    )
}
