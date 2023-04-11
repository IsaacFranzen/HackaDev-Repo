/* eslint-disable react/prop-types */
/* eslint-disable no-unused-vars */
import React from "react";
import {
  InputCampo,
  InputDados,
  LabelDados,
  SelectDados,
} from "./StylesAbas-styles";
import { useForm } from "react-hook-form";
import SelectEstados from "../../hooks/SelectEstados";
import { useState } from "react";
import SelectCidades from "../../hooks/SelectCidade";
import SelectNacionalidade from "../../hooks/SelectNacionalidade";

const SegundaAba = ({ formData, setFormData }) => {
  const [formValues, setFormValues] = useState({});
  const { register, handleSubmit } = useForm();
  const submit = (data) => console.log(data);

  const handleInputChange = (e) => {
    e.preventDefault();
    const { value, name } = e.target;
    setFormValues({ ...formValues, [name]: value });
  };

  return (
    <div
      style={{
        display: "flex",
        justifyContent: "center",
        height: "58vh",
      }}
    >
      <form onSubmit={handleSubmit(submit)} style={{ width: "90%" }}>
        <div
          style={{
            display: "flex",
            justifyContent: "space-between",
          }}
        >
          <InputCampo style={{ width: "50%" }}>
            <LabelDados>NOME DA MAE</LabelDados>
            <InputDados
              type="text"
              name="nomeMae"
              {...register("nome")}
              value={formData.nomeMae}
              onChange={(event) => {
                setFormData({ ...formData, nomeMae: event.target.value });
              }}
            />
          </InputCampo>
          <InputCampo style={{ width: "49%" }}>
            <LabelDados>NOME DO PAI</LabelDados>
            <InputDados
              type="text"
              name="nomePai"
              {...register("CPF")}
              value={formData.nomePai}
              onChange={(event) => {
                setFormData({ ...formData, nomePai: event.target.value });
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
          <InputCampo
            style={{ width: "40%", marginRight: "10px", fontSize: "16px" }}
          >
            <LabelDados>DATA DE NASCIMENTO</LabelDados>
            <InputDados
              type="date"
              name="email"
              {...register("email")}
              value={formData.dataNascimento}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  dataNascimento: event.target.value,
                });
              }}
            />
          </InputCampo>
          <InputCampo style={{ width: "30%", marginRight: "10px" }}>
            <LabelDados>SEXO</LabelDados>
            <SelectDados
              name="sexo"
              {...register("sexo")}
              value={formData.sexo}
              onChange={(event) => {
                setFormData({ ...formData, sexo: event.target.value });
              }}
            >
              <option value="feminina">FEMININA</option>
              <option value="masculina">MASCULINA</option>
              <option value="naoInformado">PREFIRO NAO INFORMAR</option>
            </SelectDados>
          </InputCampo>
          <InputCampo style={{ width: "25%", marginRight: "10px" }}>
            <LabelDados>ESTADO CIVIL</LabelDados>
            <SelectDados
              type="text"
              name="estadoCivil"
              {...register("estadoCivil")}
              value={formData.estadoCivil}
              onChange={(event) => {
                setFormData({ ...formData, estadoCivil: event.target.value });
              }}
            >
              <option value="solteiro">Solteiro</option>
              <option value="casado">Casado</option>
              <option value="separado">Separado</option>
              <option value="divorciado">Divorciado</option>
              <option value="viuvo">Viúvo</option>
            </SelectDados>
          </InputCampo>
          <InputCampo style={{ width: "40%", marginRight: "10px" }}>
            <LabelDados>DOC. DE IDENTIFICACAO</LabelDados>
            <SelectDados
              type="text"
              name="documentoIdentificacao"
              {...register("documentoIdentificacao")}
              value={formData.documentoIdentificacao}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  documentoIdentificacao: event.target.value,
                });
              }}
            >
              <option value="">Selecione..</option>
              <option value="carteiraIdentidade">Carteira de identidade</option>
              <option value="carteiraTrabalho">Carteira de trabalho</option>
              <option value="carteiraProfissional">
                Carteira profissional
              </option>
              <option value="passaporte">Passaporte</option>
            </SelectDados>
          </InputCampo>
          <InputCampo style={{ width: "30%" }}>
            <LabelDados>NUMERO</LabelDados>
            <InputDados
              type="text"
              name="numeroIdentidade"
              {...register("numeroIdentidade")}
              value={formData.numeroIdentidade}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  numeroIdentidade: event.target.value,
                });
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
          <InputCampo style={{ marginRight: "20px", width: "50%" }}>
            <LabelDados>DATA EMISSAO</LabelDados>
            <InputDados
              type="date"
              {...register("dataEmissao")}
              style={{ fontSize: "16px" }}
              value={formData.dataEmissao}
              onChange={(event) => {
                setFormData({ ...formData, dataEmissao: event.target.value });
              }}
            />
          </InputCampo>
          <InputCampo style={{ marginRight: "20px" }}>
            <LabelDados>ORGAO EXPEDIDOR</LabelDados>
            <SelectDados
              {...register("orgaoExpedidor")}
              value={formData.orgaoExpedidor}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  orgaoExpedidor: event.target.value,
                });
              }}
            >
              <option value="ssp">SSP</option>
              <option value="cartorioCivil">Cartório Civil</option>
              <option value="policia">Polícia Federal</option>
              <option value="detran">DETRAN</option>
            </SelectDados>
          </InputCampo>
          <InputCampo style={{ width: "100%" }}>
            <LabelDados>ESTADO</LabelDados>
            <SelectEstados
              onChange={handleInputChange}
              id="state"
              name="state"
              {...register("estado")}
            />
          </InputCampo>
        </div>
        <div style={{ display: "flex" }}>
          <InputCampo style={{ width: "60%", marginRight: "10px" }}>
            <LabelDados>NACIONALIDADE</LabelDados>
            <SelectNacionalidade
              id="paises"
              name="paises"
              {...register("nacionalidade")}
              value={formData.nacionalidade}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  nacionalidade: event.target.value,
                });
              }}
            />
          </InputCampo>

          <InputCampo style={{ width: "50%", marginRight: "40px" }}>
            <LabelDados>NATURALIDADE</LabelDados>
            <SelectDados
              {...register("naturalidade")}
              value={formData.naturalidade}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  naturalidade: event.target.value,
                });
              }}
            >
              <option value="">Selecione..</option>
              <option value="nato">Nato</option>
              <option value="naturalizado">Naturalizado</option>
            </SelectDados>
          </InputCampo>
          <InputCampo style={{ width: "35%" }}>
            <LabelDados>CEP</LabelDados>
            <InputDados
              type="text"
              {...register("cep")}
              value={formData.cep}
              onChange={(event) => {
                setFormData({
                  ...formData,
                  cep: event.target.value,
                });
              }}
            />
          </InputCampo>
        </div>
      </form>
    </div>
  );
};

export default SegundaAba;
