/* eslint-disable react/prop-types */
import React, { useState } from "react";
import { useForm } from "react-hook-form";
import {
  DivCheckbox,
  InputCampo,
  InputDados,
  LabelDados,
} from "./StylesAbas-styles";
import SelectCidades from "../../hooks/SelectCidade";
import SelectEstados from "../../hooks/SelectEstados";

function PrimeiraAba({ formData, setFormData }) {
  const { register, handleSubmit } = useForm();
  const [formValues, setFormValues] = useState({});

  const submit = (data) => console.log(data);

  const handleInputChange = (e) => {
    e.preventDefault();
    const { value, name } = e.target;
    setFormValues({ ...formValues, [name]: value });
  };

  console.log(formValues);

  return (
    <div
      style={{
        display: "flex",
        justifyContent: "center",
        height: "auto",
      }}
    >
      <form onSubmit={handleSubmit(submit)} style={{ width: "90%" }}>
        <div style={{ display: "flex", justifyContent: "space-between" }}>
          <InputCampo style={{ width: "60%" }}>
            <LabelDados>NOME COMPLETO</LabelDados>
            <InputDados
              type="text"
              name="nome"
              {...register("nome")}
              value={formData.nome}
              onChange={(event) => {
                setFormData({ ...formData, nome: event.target.value });
              }}
            />
          </InputCampo>
          <InputCampo style={{ width: "30%" }}>
            <LabelDados>CPF</LabelDados>
            <InputDados
              type="tel"
              name="CPF"
              {...register("CPF")}
              value={formData.cpf}
              onChange={(event) => {
                setFormData({ ...formData, cpf: event.target.value });
              }}
              maxLength={14}
            />
          </InputCampo>
        </div>
        <div
          style={{
            display: "flex",
            justifyContent: "space-between",
          }}
        >
          <InputCampo style={{ width: "45%" }}>
            <LabelDados>EMAIL</LabelDados>
            <InputDados
              type="email"
              name="email"
              {...register("email")}
              value={formData.email}
              onChange={(event) => {
                setFormData({ ...formData, email: event.target.value });
              }}
            />
          </InputCampo>
          <InputCampo style={{ width: "45%" }}>
            <LabelDados>CONFIRME SEU EMAIL</LabelDados>
            <InputDados
              type="text"
              name="confirmar-email"
              {...register("confirmar-email")}
              value={formData.confirmeEmail}
              onChange={(event) => {
                setFormData({ ...formData, confirmeEmail: event.target.value });
              }}
            />
          </InputCampo>
        </div>
        <div
          style={{
            display: "flex",
            width: "100%",
          }}
        >
          <div>
            <InputCampo style={{ width: "100%" }}>
              <LabelDados>TELEFONE RESIDENCIAL</LabelDados>
              <InputDados
                type="text"
                name="telefone-residencial"
                {...register("telefone-residencial")}
                value={formData.telefoneResidencial}
                onChange={(event) => {
                  setFormData({
                    ...formData,
                    telefoneResidencial: event.target.value,
                  });
                }}
              />
            </InputCampo>
          </div>
          <div>
            <InputCampo style={{ width: "80%", marginLeft: "10px" }}>
              <LabelDados>TELEFONE CELULAR</LabelDados>
              <InputDados
                type="text"
                name="telefone-celular"
                {...register("telefone-celular")}
                value={formData.telefoneCelular}
                onChange={(event) => {
                  setFormData({
                    ...formData,
                    telefoneCelular: event.target.value,
                  });
                }}
              />
            </InputCampo>
          </div>
        </div>
        <InputCampo>
          <label>MOTIVO ABERTURA DE CONTA</label>

          <DivCheckbox>
            <input
              type="checkbox"
              value="conta-corrente"
              {...register("conta-corrente")}
            />
            <label>Conta corrente</label>
            <input
              type="checkbox"
              value="credito-imobiliario"
              {...register("credito-imobiliario")}
            />
            <label>Credito imobiliario</label>
            <input
              type="checkbox"
              value="investimentos"
              {...register("investimentos")}
            />
            <label>Investimentos</label>
            <input type="checkbox" value="seguros" {...register("seguros")} />
            <label>Seguros</label>
          </DivCheckbox>
        </InputCampo>

        <div
          style={{
            width: "100%",
            border: "2px solid #7920be",
            marginTop: "20px",
          }}
        ></div>
        <div style={{ display: "flex" }}>
          <InputCampo style={{ width: "50%", marginLeft: "10px" }}>
            <LabelDados>ENDEREÇO</LabelDados>
            <InputDados
              type="text"
              name="endereço"
              {...register("endereço")}
              value={formData.endereco}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  endereco: event.target.value,
                });
              }}
            />
          </InputCampo>
          <InputCampo style={{ width: "50%", marginLeft: "10px" }}>
            <LabelDados>BAIRRO</LabelDados>
            <InputDados
              type="text"
              name="bairro"
              {...register("bairro")}
              value={formData.bairro}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  bairro: event.target.value,
                });
              }}
            />
          </InputCampo>
        </div>

        <div style={{ display: "flex" }}>
          <InputCampo style={{ width: "50%", marginLeft: "10px" }}>
            <LabelDados>CEP</LabelDados>
            <InputDados
              type="text"
              name="bairro"
              {...register("bairro")}
              value={formData.cep}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  cep: event.target.value,
                });
              }}
            />
          </InputCampo>
          <div style={{ display: "flex" }}>
            <InputCampo style={{ width: "50%", marginLeft: "10px" }}>
              <LabelDados>Estado</LabelDados>
              <SelectEstados
                id="state"
                name="state"
                onChange={handleInputChange}
              />
            </InputCampo>
            <InputCampo style={{ width: "50%", marginLeft: "10px" }}>
              <LabelDados>CIDADE</LabelDados>
              <SelectCidades
                id="cidade"
                name="cidade"
                state={formValues.state}
                onChange={handleInputChange}
              />
            </InputCampo>
          </div>
        </div>
      </form>
    </div>
  );
}

export default PrimeiraAba;
