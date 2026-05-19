import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { useNavigate, useParams } from 'react-router-dom'

export default function Modifyhorgas() {
    const navigation = useNavigate()
    const {id} = useParams()
    const [data, setdata] = useState(null)
    
    
    useEffect(() => {
      axios.get("https://halak.onrender.com/api/Horgaszok/"+id)
    .then((respo) => setdata(respo.data))
       
    }, [1])

    const handleSubmit = (e) => {
    event.preventDefault()
    axios.put("https://halak.onrender.com/api/Horgaszok/"+id, {
        id: Number(event.target.id.value),
        nev: event.target.name.value,
        eletkor: Number(event.target.age.value)
    })
    .then(() => 
        navigation("/")
    ).catch(error => console.log(error))
  }
if(!data){
    return
}
    
    return(
        <div className='p-5 text-center'>
            <h1>Modosit</h1>
            <form onSubmit={handleSubmit}>
                <div className='row justify-content-center'>
                    <div className='col-md-6'>
                        <div class="input-group mb-3">
                            <span class="input-group-text">Id:</span>
                            <input type="number" class="form-control" name='id' defaultValue={data.id}/>
                        </div>
                        <div class="input-group mb-3">
                            <span class="input-group-text">Nev:</span>
                            <input type="text" class="form-control" name="name" defaultValue={data.nev}/>
                        </div>
                        <div class="input-group mb-3">
                            <span class="input-group-text">Eletkor:</span>
                            <input type="number" class="form-control" name='age' defaultValue={data.eletkor}/>
                        </div>
                        <button type="submit" className="btn btn-warning">Módosítás</button>
                    </div>
                    
                </div>
            </form>
        </div>
  )
}
