import React from 'react';

import Header from '../components/Header';
import Footer from '../components/Footer';

export default function Register() {
  return (
    <div>
          <Header></Header>
          <div class="container">
    <div class="row">
        <div class="col-md-4 mx-auto mt-5 mb-5">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h4>Kayıt Ol</h4>
                </div>
            </div>
            <div class="card-body">
                <form action="" method="POST">
                    <div class="form-group">
                        <label for="username">Kullanıcı Adı</label>
                        <input type="text" name="username" class="form-control" required/>

                    </div>
                    <div class="form-group">
                        <label for="email">Mail Adresiniz</label>
                        <input type="email" name="email" class="form-control" required/>
                    </div>
                    <div class="form-group">
                        <label for="password">Şifre</label>
                        <input type="password" name="password" class="form-control" required/>

                    </div>
                    <div class="form-group  mb-3">
                        <label for="repassword">Şifre (Tekrar)</label>
                        <input type="password" name="repassword" class="form-control" required/>

                    </div>
                    <span>Eğer zaten hesabın varsa <a href='/login'>Giriş Yapabilirsin</a></span>
                    <button type="submit" class="btn btn-dark btn-lg">Kayıt Ol</button>
                </form>
            </div>
        </div>
    </div>
</div>

          <Footer></Footer>
      </div>
  )
}
