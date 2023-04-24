/* eslint-disable no-unused-vars */
/* eslint-disable react/prop-types */
import React, { useContext, useState } from "react";
import Modal from "../Modal/Modal.jsx";
import { Button, DivContainer, InputField } from "./Login-styles.js";
import { useForm } from "react-hook-form";
import { AuthContext } from "../../contexts/auth.jsx";

const Login = ({ isOpen, setModalClose }) => {
  const { handleSubmit: onSubmit, register } = useForm();
  const [conta, setConta] = useState("");
  const [senha, setSenha] = useState("");

  const { login } = useContext(AuthContext);

  const handleSubmit = (data) => {
    console.log(data);
    setModalClose();
    console.log("Submit", { conta, senha });
    login(conta, senha);
  };
  return (
    <DivContainer>
      <Modal isOpen={isOpen} setModalClose={setModalClose}>
        <form onSubmit={onSubmit(handleSubmit)}>
          <InputField>
            <span className="icon">
              <ion-icon name="person"></ion-icon>
            </span>
            <input
              type="text"
              {...register("usuario")}
              value={conta}
              onChange={(e) => setConta(e.target.value)}
            />
            <label>Conta</label>
          </InputField>
          <InputField>
            <span className="icon">
              <ion-icon name="lock-closed"></ion-icon>
            </span>
            <input
              type="password"
              required
              value={senha}
              onChange={(e) => setSenha(e.target.value)}
            />
            <label>Senha</label>
          </InputField>
          <Button type="submit">Enviar</Button>
        </form>
      </Modal>
    </DivContainer>
  );
};

export default Login;
