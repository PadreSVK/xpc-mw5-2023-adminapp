import React, { Component } from 'react';
import {Banner} from "./Banner";
import {SessionDates} from "./SessionDates";
import Slider from "./Slider";
import SponsorLogos from "./SponsorLogos";
import AccordionFaq from "./AccordionFaq";
import Footer from "./Footer";

const slides = [
    {
        heading: 'Jsme studentská akce podporovaná univerzitou',
        listItems: [
            'bla bla',
            'bla bla'
        ]
    },
    {
        heading: 'Dozvíš se, jak to chodí na vysoké, ještě než opravdu začneš studovat',
        listItems: [
            'Ukážeme ti jak se vyznat v elektronickém systému školy',
            'Poznáš studentský život nejen z pohledu studia'
        ]
    },
    {
        heading: 'Instruktoři jsou studenti vyšších ročníků ze všech fakult/kateder a oborů',
        listItems: [
            'Dáme ti tips & tricks jak se z toho nezbláznit a ulehčit si studium'
        ]
    },
    {
        heading: 'Student friendly cena',
        listItems: [
            'Levnější už to prostě být nemůže',
            'V ceně máš vše: ubytko, plnou penzi, nabitý program',
            'Doplatek je XXX a ten budeme potřebovat poslat do XXX',
            'Storno podmínky'
        ]
    },
    {
        heading: 'U nás se rozhodně nudit nebudeš',
        listItems: [
            'Těšit se můžeš nejen na informace o studiu na vysoké, ale taky na:',
            'teambuildingy s budoucími spolužáky',
            'každovečerní tématické parties',
            'přednášky',
            'a v neposlední řadě i legendární Thirsty Games!'
        ]
    },
    {
        heading: 'Top lokace a ubytko',
        listItems: [
            'Ubytováni budeme ve zrekonstruovaných chatkách v kempu RS JIskra/v tom ostravským',
            'V kempu bude téměř nonstop otevřený bar',
            'Sportoviště atd'
        ]
    },
    {
        heading: 'Individuálně přizpůsobená strava',
        listItems: [
            'Klasická, vegetariánská, veganská, bezlepková i bezlaktózová'
        ]
    },
    {
        heading: 'Doprava do kempu zajištěna',
        listItems: [
            'Do kempu můžeš přijet buď po vlastní ose (auto lze parkovat zdarma), nebo zdarma naším pronajatým autobusem od VŠPJ v XXh 11./14. 9. (podle volby turnusu)'
        ]
    }

];

const faqs = [
    {
        question: "Kde se budeme stravovat?",
        answer: "Co ja vim",
    },
    {
        question: "Kde si mám zažádat o speciální stravu?",
        answer: "Co ja vim",
    },
    {
        question: "Jak mohu editovat přihlášku?",
        answer: "Co ja vim",
    },
    {
        question: "Jaký je můj variabilní symbol pro platbu?",
        answer: "Co ja vim",
    },
    {
        question: "Co když jsem již zaplatil/a, ale v sekci “moje přihláška” nemám stále potvrzenou platbu?",
        answer: "Co ja vim",
    },
    {
        question: "Mohu jet na oba termíny současně nebo naopak jen na část jednoho termínu?",
        answer: "Co ja vim",
    },
    {
        question: "Storno",
        answer: "Co ja vim",
    },
    {
        question: "Berou v kempu karty?",
        answer: "Co ja vim",
    },
    {
        question: "Je v kempu obchod?",
        answer: "Co ja vim",
    },
    {
        question: "Co když mám během Adapťáku přihlašování předmětů?",
        answer: "Co ja vim",
    },
    {
        question: "Můžu s kamarády bydlet společně?",
        answer: "Co ja vim",
    },
    {
        question: "Může jet i někdo, kdo nestuduje na naší vysoké?",
        answer: "Co ja vim",
    },
    {
        question: "Mohou bydlet i kluci s holkama a naopak?",
        answer: "Co ja vim",
    },
    {
        question: "Co nezapomenout sbalit?",
        answer: "Co ja vim",
    },
    {
        question: "Nepřišel mi informační email",
        answer: "Co ja vim",
    },
    {
        question: "Budou z Adapťáku nějaké fotky?",
        answer: "Co ja vim",
    },
    {
        question: "Ztráty a nálezy.",
        answer: "Co ja vim",
    },
];

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
        <div>
            <Banner />
            <SessionDates />
            <Slider slides={slides}/>
            <SponsorLogos/>
            <AccordionFaq faqs={faqs} />
        </div>
    );
  }
}
