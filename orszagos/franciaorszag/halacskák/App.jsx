import { useState } from 'react'
import {BrowserRouter, NavLink, Route, Routes, Link} from 'react-router-dom'
import './App.css'
import Home from './Home';
import Balaton from './Balaton';
import Horgaszok from './Horgaszok';
import Nav from './Nav';
import Singlehal from './Singlehal';
import NewHal from './NewHal';
import Modifyhorgas from './Modifyhorgas';


function App() {

  return (
    <>
      <BrowserRouter>
      <Nav/>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/horgaszok" element={<Horgaszok />} />
        <Route path="/balaton" element={<Balaton />} />
        <Route path="/singlehal/:id" element={<Singlehal />} />
        <Route path="/newhal" element={<NewHal />} />
        <Route path="/modifyhorgas/:id" element={<Modifyhorgas />} />
        
        
      </Routes>
    </BrowserRouter>

    </>
  )
}

export default App
