import React from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./styles/globals.js";

import Home from "./pages/Home";
import About from "./pages/About";
import Layout from "./components/Layout/Layout";
import Saldo from "./components/saldo/saldocomponent";

function App() {
  return (
    <>
      <BrowserRouter>
        <Routes>
          <Route exact path="/" element={<Home />} />
          <Route path="/about" element={<About />} />
          <Route path="/teste" element={<Saldo />} />
        </Routes>
      </BrowserRouter>

      <Layout />
    </>
  );
}

export default App;
