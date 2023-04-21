import styled from "styled-components";

export const Background = styled.div`
  position: fixed;
  top: 0;
  left: 0;
  background: rgba(0,0,0, 0.7);
  width: 100%;
  height: 100%;
  z-index: 1000;
  display: flex;
  justify-content: center;
  align-items: center
`;

export const Wrapper = styled.div`
  position: absolute;
  width: 400px;
  padding: 40px;
  color: #000;
  background: #fff;
  border: 1px solid #8c8686;
  border-radius: 10px;
  box-shadow: 0 0 30px rgba(0, 0, 0, 0.5);
  display: flex;
  justify-content: center;
  align-items: center;
  transition: transform 0.5s ease, height 0.2s ease;
  z-index: 999;

  h2 {
    font-size: 1.7em;
    text-align: center;
    margin: 0;
  }

  .active-popup {
    transform: scale(1);
  }

  .active-popup-recup {
    transform: scale(1);
  }

  .active-termos-servicos {
    transform: scale(1);
  }

  .active {
    transform: scale(1);
  }

  .active {
    height: 520px;
  }
  
  .active-termos-servicos {
    width: 500px;
    height: 820px;
    font-size: 13px;
  }
  .active-popup-recup {
    height: 380px;
  }

  .form-box {
    width: 100%;
    padding: 40px;
  }

  .form-box.termos-servico {
    position: absolute;
    transition: none;
    transform: translateX(-800px);
  }

  .active-termos-servicos .form-box.termos-servico {
    transition: transform 0.18s ease;
    transform: translateX(0);
  }

  .form-box.login {
    /* display: none; */
    transition: transform 0.18s ease;
    transform: translateX(0);
  }

  .active .form-box.login {
    transition: none;
    transform: translateX(800px);
  }
  .active-popup-recup .form-box.login {
    transition: none;
    transform: translateX(600px);
  }
  .active-termos-servicos .form-box.login {
    transition: none;
    transform: translateX(600px);
  }

  .form-box.recupera {
    position: absolute;
    transition: none;
    transform: translateX(600px);
  }

  .active-popup-recup .form-box.recupera {
    transition: transform 0.18s ease;
    transform: translateX(0);
  }

  .form-box.cadastro {
    position: absolute;
    transition: none;
    transform: translateX(-600px);
  }

  .active .form-box.cadastro {
    transition: transform 0.18s ease;
    transform: translateX(0);
  }

  .back-login {
    text-decoration: none;
  }
  .back-login-cadastro {
    text-decoration: none;
  }
`;

export const IconClose = styled.div`
  position: absolute;
  top: 0;
  right: 0;
  width: 45px;
  height: 45px;
  font-size: 2em;
  color: #791ebe;
  display: flex;
  justify-content: center;
  align-items: center;
  cursor: pointer;
  z-index: 1;
`;