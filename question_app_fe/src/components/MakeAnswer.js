import React from 'react'

export const MakeAnswer = () => {
    return (
        <div className='mt-5'>
            <div className=''>
                <div class="mb-3">
                    <label for="exampleFormControlTextarea1" class="form-label">Soruyu Cevapla</label>
                    <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
                </div>

                <button className='btn btn-success'>
                    Soruyu Cevapla
                </button>
            </div>
        </div>
    )
}
