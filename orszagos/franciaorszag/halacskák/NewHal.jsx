import axios from 'axios'
import React from 'react'
import { useNavigate } from 'react-router-dom'

export default function NewHal() {
    const navigation = useNavigate()

    const handleSubmit = (event) => {
    event.preventDefault()

    axios.post("https://halak.onrender.com/api/Horgaszok",{
        id: Number(event.target.id.value),
        nev: event.target.name.value,
        eletkor: Number(event.target.origine.value)
        })
        .then(()=>{
            navigation("/")
        })
        .catch(error =>
        console.log(error)
    )

  }
    
    

  return (
    <div className="p-5 text-center">
      <h1>Uj hal</h1>
      <form onSubmit={handleSubmit}>
      <div className="row justify-content-center">
        <div className="col-md-6">

          <div className="input-group mb-3">
            <label className="input-group-text">Id:</label>
            <input type="number" name="id" className="form-control" />
          </div>

          <div className="input-group mb-3">
            <label className="input-group-text">Neve:</label>
            <input type="text" name="name" className="form-control" />
          </div>

          <div className="input-group mb-3">
            <label className="input-group-text">Eletkor:</label>
            <input type="text" name="origine" className="form-control" />
          </div>

          <button type="submit" className="btn btn-success">Küldés</button>

        </div>
      </div>
      </form>
    </div>
  )
}
