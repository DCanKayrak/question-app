import React from 'react'
import Header from '../components/Header'
import Footer from '../components/Footer'

export const Login = () => {
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
                                    <label for="username">Kullanıcı Adı</label>
                                    <input type="text" name="username" class="form-control" required />

                                </div>
                                <div class="form-group mb-3">
                                    <label for="password">Şifre</label>
                                    <input type="password" name="password" class="form-control" required />
                                </div>
                                <span>Eğer zaten hesabın yoksa <a href='/register'>Kayıt Olmak için</a></span>
                                <button type="submit" class="btn btn-dark btn-lg">Giriş Yap</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

