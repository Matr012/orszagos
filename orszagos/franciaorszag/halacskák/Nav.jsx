import React from 'react'
import { Link } from 'react-router-dom'

export default function Nav() {
  return (
    <div>
        <nav className="navbar navbar-expand-lg bg-body-tertiary">
  <div className="container-fluid">
    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span className="navbar-toggler-icon"></span>
    </button>
    <div className="collapse navbar-collapse" id="navbarNavAltMarkup">
      <div className="navbar-nav">
        <Link to={"/"} className="nav-link active" aria-current="page">Halak</Link>
        <Link to={"/horgaszok"} className="nav-link" >Horgaszok</Link>
        <Link to={"/balaton"} className="nav-link">Balaton</Link>
        <Link to={"/newhal"} className="nav-link">Uj Hal</Link>
        

      </div>
    </div>
  </div>
</nav>


    </div>
  )
}
