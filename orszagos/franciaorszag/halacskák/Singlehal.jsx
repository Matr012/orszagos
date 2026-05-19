import axios from 'axios'
import React, { use, useEffect, useState } from 'react'
import { data, Link, useParams } from 'react-router-dom'
export default function Singlehal() {
    const {id} = useParams()
    const [data, setdata] = useState(null)
    useEffect(() => {
      axios.get("https://halak.onrender.com/api/Halak/"+id)
    .then((resp) => setdata(resp.data))
    }, [1])

if(!data){
    return
}
    
  return (
    <div >
      <div className="card container" style={{width: "18rem"}}>
        <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRr-J6WOsqBtFrGEOx_K7ZnyTvpss4UMhXewnMlQY-rtmlBwO83C5DJ4iaYAw-8Ri2IBYBkw3PWppldbl0-FQxMWLAhI8DwtL0-KxzYSQJV&s=10" className="card-img-top" />
        <div className="card-body text-center">
          <h1 className="card-text">{data.nev}</h1>
           <h1 className="card-text">{data.faj}</h1>
            <h1 className="card-text">{data.meretCm}</h1>
            <Link to={"/"}>Vissza</Link>
        </div>
      </div>
    </div>
  )
}