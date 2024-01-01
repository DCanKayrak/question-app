import React from 'react';

import Header from '../components/Header';
import Footer from '../components/Footer';

export const Register = () => {
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
                            <form class="mb-3">
                                <div class="form-group">
                                    <label for="username">Kullanıcı Adı</label>
                                    <input type="text" name="username" class="form-control" required />
                                </div>
                                <div class="form-group">
                                    <label for="username">Adınız</label>
                                    <input type="text" name="username" class="form-control" required />
                                </div>
                                <div class="form-group">
                                    <label for="username">Kullanıcı Adı</label>
                                    <input type="text" name="username" class="form-control" required />
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
                                    <label for="inputPassword5" class="form-label">Şifre</label>
                                    <input type="password" id="inputPassword5" class="form-control" aria-describedby="passwordHelpBlock" />
                                </div>

                                <div class="form-group">
                                    <label for="inputPassword5" class="form-label">Şifre (Tekrar)</label>
                                    <input type="password" id="inputPassword5" class="form-control" aria-describedby="passwordHelpBlock" />
                                    <div id="passwordHelpBlock" class="form-text">
                                        Şifreniz 8 harften kısa olamaz
                                    </div>
                                </div>
                            </form>
                            <div class='mb-3'><span>Eğer zaten hesabın varsa <a href='/login'>Giriş yapmak için</a></span></div>

                            <button type="submit" class="btn btn-dark btn-lg">Kayıt Ol</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

