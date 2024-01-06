import { React, useEffect, useState } from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';
import { useNavigate } from "react-router";
import { PostWithoutAuth } from '../utils/service/HttpService';

export const Login = () => {

    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const navigate = useNavigate();

    const sendRequest = () => {
        PostWithoutAuth(("http://localhost:7048/api/Auth/Login"),{
            email: email,
            password:password
        })
            .then((res) => res.json())
            .then((result) => {
                localStorage.setItem("tokenKey", result.token);
            }).catch((err) => console.log(err))
    }


    const handleRegister = () => {
        sendRequest()
        setEmail("")
        setPassword("")
        //navigate("/")
    }

    useEffect(() => {
        console.log(email)
        console.log(password)
    },[email,password])

    return (
        <div className='align-center justify-content-center'>
            <div>
                <div class="container">
                    <div class="col-md-4 mx-auto mt-5 mb-5 shadow p-3 mb-5 bg-body-tertiary rounded p-5">
                        <div class="card">
                            <div class="card-header bg-dark text-white">
                                <h4>Giriş Yap</h4>
                            </div>
                        </div>
                        <div class="card-body">
                            <form>
                                <div class="form-group">
                                    <label for="username">Mail Adresiniz</label>
                                    <input onChange={event => setEmail(event.target.value)} type="text" name="email" class="form-control" required />

                                </div>
                                <div class="form-group mb-3">
                                    <label for="password">Şifre</label>
                                    <input onChange={event => setPassword(event.target.value)} type="password" name="password" class="form-control" required />
                                </div>
                                <span>Eğer zaten hesabın yoksa <a href='/register'>Kayıt Olmak için</a></span>
                                <button onClick={handleRegister} class="btn btn-dark btn-lg">Giriş Yap</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

