import React, { useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { PostWithAuth } from '../utils/service/HttpService'

export const MakeAnswer = () => {
    const [text, setText] = useState(null);

    const { questionId } = useParams();

    const [error, setError] = useState("");
    const [success, setSuccess] = useState("");
  
    const navigate = useNavigate();

    const handleAnswer = () => {
        PostWithAuth("https://localhost:7048/api/Answer", {
            questionId: questionId,
            text: text
        })
            .then((res) => res.json())
            .then((result) => {
                if (result.success) {
                    window.location.reload();
                    setError(null)
                    setSuccess(result.message)
                }
                else {
                    setSuccess(null)
                    setError(result.message)
                }
            }).catch((err) => console.log(err.message))
    }

    return (
        <div className='mt-5'>
            <div className=''>
                <div class="mb-3">
                    <label for="exampleFormControlTextarea1" class="form-label">Soruyu Cevapla</label>
                    <textarea onChange={ event => setText(event.target.value)} required class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
                </div>

                <button onClick={ handleAnswer } className='btn btn-success'>
                    Soruyu Cevapla
                </button>
                <button className='btn btn-warning'><i class="fa-solid fa-arrow-up-from-bracket"></i> Resim İle Cevap Ver</button>
            </div>
        </div>
    )
}
