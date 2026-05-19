import axios from 'axios'
import React, { useEffect, useState } from 'react'
import { Link } from 'react-router-dom'

export default function Home() {
    const [data, setdata] = useState(null)
    
    useEffect(() => {
        axios.get("https://halak.onrender.com/api/Halak")
        .then((resp) => setdata(resp.data))

   
  }, [])

  
    return (
    <div className='row'>

       {data && data.map((x, index) => {return (
            <div className="col-4 card" key={index}>
                <div className="card-body ">
                    <Link to={"/singlehal/"+ x.id} className='text-decoration-none text-dark'> {x.nev}</Link>
                </div>
            </div>
        )})}
        
    </div>
  )
}
