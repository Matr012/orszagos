import React, { useEffect, useState } from 'react'
import axios from 'axios'
import { useNavigate, useParams } from 'react-router-dom'

export default function Edithorgasz() {
  const { id } = useParams()
  const navigate = useNavigate()
  const [data, setData] = useState(null)

  useEffect(() => {
    axios.get(`https://halak.onrender.com/api/Horgaszok/${id}`)
      .then((resp) => setData(resp.data))
  }, [id])

  const handleSubmit = (event) => {
    event.preventDefault()

    axios.put(`https://halak.onrender.com/api/Horgaszok/${id}`, {
      id:      Number(id),
      nev:     event.target.nev.value,
      eletkor: Number(event.target.eletkor.value)
    })
    .then(() => {
      navigate("/horgaszok")
    })
    .catch(error => {
      console.log(error)
    })
  }

  return (
    <div className="p-5 text-center">
      <h1>Horgász módosítása</h1>
      {data && (
        <form onSubmit={handleSubmit}>
          <div className="row justify-content-center">
            <div className="col-md-6">

              <div className="input-group mb-3">
                <label className="input-group-text">Név:</label>
                <input type="text" name="nev" className="form-control" defaultValue={data.nev} />
              </div>

              <div className="input-group mb-3">
                <label className="input-group-text">Életkor:</label>
                <input type="number" name="eletkor" className="form-control" defaultValue={data.eletkor} />
              </div>

              <button type="submit" className="btn btn-warning">Módosítás</button>

            </div>
          </div>
        </form>
      )}
    </div>
  )
}