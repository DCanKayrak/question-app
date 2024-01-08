import { React, useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';

import { PostWithoutAuth } from '../utils/service/HttpService';

import Header from '../components/Header';
import Footer from '../components/Footer';

export const Register = () => {

    
    const [email, setEmail] = useState("");
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [password, setPassword] = useState("");
    const [repassword, setRepassword] = useState("");

    const [error, setError] = useState("");
    const [success, setSuccess] = useState("");

    const navigate = useNavigate();

    const sendRequest = () => {
        PostWithoutAuth(("https://localhost:7048/api/Auth/Register"),{
            email: email,
            firstName: firstName,
            lastName: lastName,
            password:password
        })
            .then((res) => res.json())
            .then((result) => {
                if(result.success){
                    setError(null)
                    setSuccess(result.message)
                    navigate("/")
                }
                else {
                    setSuccess(null)
                    console.log(result.message)
                    setError(result.message)
                }
                
            }).catch((err) => console.log(err.message))
    }


    const handleRegister = () => {
        if (password === repassword) {
            sendRequest()
        }
        else {
            console.log("Şifreler aynı değil.")
        }
        
        setEmail("")
        setFirstName("")
        setLastName("")
        setPassword("")
    }

    useEffect(() => {
    },[email,password,error])

    return (
        <div className='align-center justify-content-center'>
            <div>
                <div class="container">
                    <div class="col-md-4 mx-auto mt-5 mb-5 shadow p-3 mb-5 bg-body-tertiary rounded p-5">
                        <div class="card">
                            <div class="card-header bg-dark text-white">
                                <h4>Kayıt Ol</h4>
                            </div>
                        </div>
                        <div class="card-body">
                        {success == null ? <div className='bg-danger'>{error}</div> : <div className='bg-success'>{success}</div>}
                            <form class="mb-3">
                                <div class="form-group">
                                    <label for="email">Mail Adresiniz</label>
                                    <input onChange={ event => setEmail(event.target.value) } type="text" name="email" class="form-control" required />
                                </div>
                                <div class="form-group">
                                    <label for="firstname">Adınız</label>
                                    <input onChange={ event => setFirstName(event.target.value) } type="text" name="firstname" class="form-control" required />
                                </div>
                                <div class="form-group">
                                    <label for="lastname">Soyadınız</label>
                                    <input onChange={ event => setLastName(event.target.value) } type="text" name="lastname" class="form-control" required />
                                </div>

                                <div class='form-group mt-3 mb-3'>
                                    <label for="username">Kullanıcı Tipi</label>
                                    <select class="form-select" aria-label="Default select example">
                                        <option disabled selected>Seçim Yapınız</option>
                                        <option value="1">Öğrenci</option>
                                        <option value="2">Öğretmen</option>
                                    </select>
                                </div>

                                <div class="form-group">
                                    <label for="password" class="form-label">Şifre</label>
                                    <input onChange={ event => setPassword(event.target.value) } type="password" id="password" class="form-control" aria-describedby="passwordHelpBlock" />
                                </div>

                                <div class="form-group">
                                    <label for="repassword" class="form-label">Şifre (Tekrar)</label>
                                    <input onChange={ event => setRepassword(event.target.value) } type="password" id="repassword" class="form-control" aria-describedby="passwordHelpBlock" />
                                    <div id="passwordHelpBlock" class="form-text">
                                        Şifreniz 8 harften kısa olamaz
                                    </div>
                                </div>
                            </form>
                            <div class='mb-3'><span>Eğer zaten hesabın varsa <a href='/login'>Giriş yapmak için</a></span></div>
                            <button onClick={ handleRegister } class="btn btn-dark btn-lg">Kayıt Ol</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

