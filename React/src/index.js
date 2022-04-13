import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import { BrowserRouter, Route, Routes } from "react-router-dom"
import Teachers from './Pages/Teachers';

ReactDOM.render(
  <BrowserRouter>
    <Routes>
      <Route path="/" element={<App />} />
      <Route path="/teachers" element={<Teachers />} />
    </Routes>
  </BrowserRouter>,
  document.getElementById('root')
);
