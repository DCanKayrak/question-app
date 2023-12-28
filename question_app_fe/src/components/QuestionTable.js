import React from 'react'

export default function QuestionTable() {
    return (
        <div>
            <table class="table">
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
                        <th scope="row">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>@mdo</td>
                    </tr>
                </tbody>
            </table>
        </div>
    )
}
