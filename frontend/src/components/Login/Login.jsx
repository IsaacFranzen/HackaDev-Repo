/* eslint-disable no-unused-vars */
/* eslint-disable react/prop-types */
import React, { useContext, useState } from "react";
import Modal from "../Modal/Modal.jsx";
import { Button, DivContainer, InputField } from "./Login-styles.js";
import { useForm } from "react-hook-form";
import { AuthContext } from "../../contexts/auth.jsx";

const Login = ({ isOpen, setModalClose }) => {
  const { handleSubmit: onSubmit, register } = useForm();
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const { authenticated, login } = useContext(AuthContext);

  const handleSubmit = (data) => {
    console.log(data);
    setModalClose();
    console.log("Submit", { email, password });
    login(email, password);
  };
  return (
    <DivContainer>
      <Modal isOpen={isOpen} setModalClose={setModalClose}>
        <p>{String(authenticated)}</p>
        <form onSubmit={onSubmit(handleSubmit)}>
          <InputField>
            <span className="icon">
              <ion-icon name="person"></ion-icon>
            </span>
            <input
              type="text"
              {...register("usuario")}
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
            <label>E-mail</label>
          </InputField>
          <InputField>
            <span className="icon">
              <ion-icon name="lock-closed"></ion-icon>
            </span>
            <input
              type="password"
              required
              value={password}
              onChange={(e) => setPassword(e.target.value)}
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
