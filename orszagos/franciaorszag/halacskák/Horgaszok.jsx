import axios from 'axios'
import React, { lazy, useEffect, useState } from 'react'
import { Link, useNavigate } from 'react-router-dom'

export default function Horgaszok() {
  const [data, setdata] = useState(null)
  const navigation = useNavigate()
  useEffect(() => {
    axios.get("https://halak.onrender.com/api/Horgaszok/")
    .then((resp) => setdata(resp.data))
  }, [])
  
  function kattintas(id){
    let torles = confirm("Biztos")
    if (torles){
        axios.delete("https://halak.onrender.com/api/Horgaszok/"+id)
        .then(res =>{
            console.log("siker")
            alert("Siker")
            navigation("/")
        })
        .catch(error => {
            console.log(error)

        })
        

        
    }
}

    return (
    <div>
        <ul >
        {data && data.map((x, index) => {return(
            
            <li key={index}>
                <Link to={"/modifyhorgas/"+x.id}>
                {x.id} {x.nev} <button onClick={() => kattintas(x.id)} type="button" class="btn btn-light"><i className="bi bi-trash"></i></button>
                </Link>
            </li>
            
        )})}
        </ul>
    </div>
  )
}
