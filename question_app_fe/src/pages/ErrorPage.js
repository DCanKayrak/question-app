import React from 'react'

export const ErrorPage = () => {
    return (
        <div>
            <section class="page_404">
                <div class="container">
                    <div class="row">
                        <div class="col-sm-12 d-flex justify-content-center">
                            <div class="col-sm-10 col-sm-offset-1 text-center">
                                <div class="four_zero_four_bg">
                                    <h1 class="text-center text-primary">404</h1>
                                </div>
                                <div class="contant_box_404">
                                    <h3 class="h2">
                                        Kaybolmuşa benziyorsun :)
                                    </h3>

                                    <p>Aradığınız sayfa bulunamadı!</p>

                                    <a href="/" class="btn btn-primary">Anasayfaya Dön</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <div className='btn-close-sidebar'></div>
        </div>
    )
}