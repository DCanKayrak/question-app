import React from 'react'

export default function QuestionTable() {
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
                    <tr>
                        <th scope="row"><a href='/questions/1'>Div Nasıl Ortalanır ? </a></th>
                        <td>Yazılım</td>
                        <td><p><i style={{color: 'green'}} class="fa-solid fa-circle-check"></i> Cevaplandı</p></td>
                        <td>Mehmet</td>
                    </tr>
                    <tr>
                        <th scope="row">EntityFramework Hk. </th>
                        <td>Yazılım</td>
                        <td><p><i style={{color: 'green'}} class="fa-solid fa-circle-check"></i> Cevaplandı</p></td>
                        <td>Ahmet</td>
                    </tr>
                    <tr>
                        <th scope="row">Div Nasıl Ortalanır ? </th>
                        <td>Yazılım</td>
                        <td><p><i style={{color: 'red'}} class="fa-solid fa-circle-xmark"></i> Cevaplanmadı</p></td>
                        <td>Cevdet</td>
                    </tr>
                    <tr>
                        <th scope="row">Div Nasıl Ortalanır ? </th>
                        <td>Yazılım</td>
                        <td><p><i style={{color: 'red'}} class="fa-solid fa-circle-xmark"></i> Cevaplanmadı</p></td>
                        <td>Fikret</td>
                    </tr>
                </tbody>
            </table>
        </div>
    )
}
