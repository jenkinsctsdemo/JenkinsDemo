#!/bin/bash
cp /etc/hosts /etc/hosts.bak
cp /etc/ssh/sshd_config /etc/ssh/sshd_config.bak
echo '10.253.245.154 svnsonarbkup.metlife.com svnsonarbkup' >> /etc/hosts
echo ClientAliveInterval 60 >> /etc/ssh/sshd_config
echo ClientAliveCountMax 60 >> /etc/ssh/sshd_config
service ssh restart
